/* ========================================================================
 * Copyright 2019 Andrew Roos. 
 *
 * This file is part of the OPC UA Honeypot.
 *
 * The OPC UA Honeypot is free software: you can redistribute it and/or 
 * modify it under the terms of the GNU General Public License as published 
 * by the Free Software Foundation, either version 3 of the License, or
 * (at your option) any later version.
 *
 * The OPC UA Honeypot is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details.
 *
 * You should have received a copy of the GNU General Public License
 * along with the OPC UA Honeypot..  If not, see 
 * <https://www.gnu.org/licenses/>.
 * ======================================================================*/

using System;
using System.Collections.Generic;
using System.Net;

namespace Opc.Ua.Honeypot
{
    /// <summary>
    /// Validate username/password comibations for the honeypot. Only usernames and passwords from a list of likely usernames
    /// and a list of common passwords will be accepted. Once a particular password has been accepted for a username, then
    /// no other password will be accepted for that username for a random expiry period. If no password has been accepted for 
    /// a username, then the probability that a new password from the list of common passwords will be accepted is 
    /// probLuckyGuess. The username/password information is not stored persistently, so the system resets on each startup.
    /// The validator implements a backdoor username and password, which will always be accepted. 
    /// </summary>
    class CredentialValidator
    {
        /// <summary>
        /// Create a new credential validator. 
        /// </summary>
        /// <param name="backdoorUsername">The backdoor username that will always be accepted.</param>
        /// <param name="backdoorPassword">The password for the backdoor username.</param>
        /// <param name="probLuckyGuess">The probability that a new password will be accepted for a username with no password.</param>
        /// <param name="minExpiryDays">The minimum no. of days that a newly allocated password will be valid.</param>
        /// <param name="maxExpiryDays">The maximum no. of days that a newly allocated password will be valid.</param>
        /// <param name="maxRenewalDays">The minimum no. of days maximum no. of days to renew a password for when it is used.</param>
        /// <param name="maxRenewalDays">The maximum no. of days maximum no. of days to renew a password for when it is used.</param>


        public CredentialValidator(String backdoorUsername, String backdoorPassword, double probLuckyGuess, double minExpiryDays, 
            double maxExpiryDays, double minRenewalDays, double maxRenewalDays)
        {
            m_backdoorUsername = backdoorUsername;
            m_backdoorPassword = backdoorPassword;
            m_probLuckyGuess = probLuckyGuess;
            m_minExpiryDays = minExpiryDays;
            m_maxExpiryDays = maxExpiryDays;
            m_minRenewalDays = minRenewalDays;
            m_maxRenewalDays = maxRenewalDays;

            // Register the usernames that may be accepted. All other usernames (apart from the backdoor username) will always be
            // rejected, since accepting random usernames would reveal that the server is a honeypot. 
            RegisterUsernames(new string[] {
                "adm","admin","Administrator","audit","cell1","daemon","eng","engineer","engineering","factory","guest","info","informix",
                "inspection","inspector","line","line1","man","manager","manuf","manufacturing","master","modbus","mysql","opc","opcua",
                "oracle","peng","production","profi","profibus","profinet","qa","qc","quality","remote","root","sa","su","supervisor",
                "support","sys","sysadm","sysadmin","tech","technician","test","tester","ua","user"
            });

            // Register the passwords that may be accepted. All other passwords (apart from the backdoor password) will always be
            // rejected, since accepting random passwords would reveal that the server is a honeypot. These are the 1000 most common 
            // passwords according to the UK National Cybersecurity Centre (https://www.ncsc.gov.uk/blog-post/passwords-passwords-everywhere).
            RegisterPasswords(new string[] {
                "123456", "123456789", "qwerty", "password", "111111", "12345678", "abc123", "1234567", "password1", "12345",
                "1234567890", "123123", "000000", "iloveyou", "1234", "1q2w3e4r5t", "qwertyuiop", "123", "monkey", "dragon",
                "123456a", "654321", "123321", "666666", "1qaz2wsx", "myspace1", "121212", "homelesspa", "123qwe", "a123456",
                "123abc", "1q2w3e4r", "qwe123", "7777777", "qwerty123", "target123", "tinkle", "987654321", "qwerty1", "222222",
                "zxcvbnm", "1g2w3e4r", "gwerty", "zag12wsx", "gwerty123", "555555", "fuckyou", "112233", "asdfghjkl", "1q2w3e",
                "123123123", "qazwsx", "computer", "princess", "12345a", "ashley", "159753", "michael", "football", "sunshine",
                "1234qwer", "iloveyou1", "aaaaaa", "fuckyou1", "789456123", "daniel", "777777", "princess1", "123654", "11111",
                "asdfgh", "999999", "11111111", "passer2009", "888888", "love", "abcd1234", "shadow", "football1", "love123",
                "superman", "jordan23", "jessica", "monkey1", "12qwaszx", "a12345", "baseball", "123456789a", "killer", "asdf",
                "samsung", "master", "azerty", "charlie", "asd123", "soccer", "FQRG7CS493", "88888888", "jordan", "michael1",
                "jesus1", "linkedin", "babygirl1", "789456", "blink182", "thomas", "qwer1234", "333333", "liverpool", "michelle",
                "nicole", "qwert", "j38ifUbn", "131313", "asdasd", "0", "987654", "lovely", "q1w2e3r4", "0123456789",
                "gfhjkm", "andrew", "hello1", "joshua", "Status", "justin", "anthony", "angel1", "iloveyou2", "1111111",
                "zxcvbn", "hello", "1111", "jennifer", "hunter", "naruto", "bitch1", "welcome", "159357", "101010",
                "tigger", "147258369", "babygirl", "jessica1", "parola", "5201314", "robert", "fuckyou2", "696969", "102030",
                "0987654321", "loveme", "123456q", "apple", "pokemon", "mother", "money1", "secret", "anthony1", "purple",
                "q1w2e3r4t5y6", "baseball1", "qazwsxedc", "1111111111", "abc", "buster", "matthew", "andrea", "soccer1", "basketball",
                "hannah", "freedom", "golfer", "chelsea", "passw0rd", "george", "trustno1", "friends", "william", "iloveu",
                "amanda", "number1", "chocolate", "qwerty12", "summer", "flower", "charlie1", "maggie", "pakistan", "samantha",
                "asdf1234", "letmein", "asshole1", "superman1", "marina", "147258", "batman", "fuk19600", "butterfly", "010203",
                "qweqwe", "29rsavoy", "forever", "1", "mustang", "sunshine1", "ashley1", "internet", "london", "666",
                "harley", "alexander", "xbox360", "00000000", "12341234", "q1w2e3", "pepper", "family", "loveyou", "50cent",
                "joseph", "whatever", "!", "jasmine", "orange", "user", "junior", "cookie", "martin", "qweasdzxc",
                "212121", "1qazxsw2", "password12", "google", "password2", "111222", "lol123", "hello123", "jordan1", "shadow1",
                "patrick", "3rJs1la7qE", "ginger", "nicole1", "mylove", "arsenal", "12344321", "abcdef", "love12", "232323",
                "VQsaBLPzLa", "taylor", "myspace", "brandon", "angel", "12345q", "brandon1", "chris1", "diamond", "snoopy",
                "asshole", "qweasd", "starwars", "matrix", "mickey", "school", "jonathan", "melissa", "eminem", "1234561",
                "cjmasterinf", "lovers", "1234567891", "nikita", "richard", "1342", "yellow", "12345qwert", "oliver", "q1w2e3r4t5",
                "cheese", "a123456789", "christian", "290966", "wall.e", "12345678910", "12413", "sophie", "tudelft", "DIOSESFIEL",
                "dpbk1234", "PE#5GZ29PTZMSE", "bailey", "U38fa39", "mercedes", "victoria", "147852", "asdasd5", "matthew1", "abcdefg",
                "peanut", "456789", "red123", "happy1", "sandra", "benjamin", "dragon1", "444444", "123654789", "$HEX",
                "elizabeth", "prince", "amanda1", "angels", "angela", "qqqqqq", "samuel", "banana", "barcelona", "ghbdtn",
                "computer1", "michelle1", "william1", "hockey", "monster", "carlos", "justin1", "antonio", "qwertyu", "nathan",
                "55555", "123789", "0000", "killer1", "11223344", "chicken", "lucky1", "gabriel", "welcome1", "zaq12wsx",
                "jasmine1", "silver", "hunter1", "bubbles", "hottie1", "purple1", "andrew1", "daniel1", "liverpool1", "1qaz2wsx3edc",
                "rainbow", "morgan", "natasha", "fuckoff", "jackson", "austin", "vanessa", "mommy1", "madison", "adidas",
                "xxxxxx", "252525", "america", "james1", "metallica", "slipknot", "chicken1", "87654321", "jesus", "NULL",
                "0000000000", "alexis", "!ab#cd$", "spiderman", "steven", "ferrari", "lauren", "456123", "robert1", "147852369",
                "qwaszx", "buddy1", "butterfly1", "!~!1", "tinkerbell", "bandit", "danielle", "0123456", "nicholas", "hannah1",
                "qwerty12345", "1234554321", "asdfasdf", "pokemon1", "nirvana", "destiny", "scooter", "cookie1", "123qweasd", "loveme1",
                "chelsea1", "chocolate1", "1234567a", "juventus", "rachel", "111222tianya", "qazxsw", "zzzzzz", "monica", "stella",
                "america1", "999999999", "jennifer1", "freedom1", "taylor1", "741852963", "yamaha", "victor", "00000", "qwertyui",
                "a1b2c3", "ronaldo", "1password", "smokey", "david1", "money", "daddy1", "cocacola", "a838hfiD", "1234abcd",
                "joshua1", "123asd", "buster1", "myspace123", "booboo", "madison1", "samantha1", "heather", "7654321", "elizabeth1",
                "poop", "tigger1", "family1", "mustang1", "142536", "november", "jasper", "lovely1", "diamond1", "success",
                "edward", "music1", "valentina", "harley1", "sweety", "tennis", "zxc123", "friend", "qaz123", "whatever1",
                "thomas1", "nothing", "N0=Acc3ss", "super123", "casper", "Password", "chester", "Exigent", "password123", "cheese1",
                "spongebob1", "mynoob", "hahaha", "hellokitty", "098765", "alexandra", "canada", "david", "1q2w3e4r5t6y", "dennis",
                "december", "olivia", "a1b2c3d4", "playboy", "sabrina", "patricia", "summer1", "friends1", "mexico1", "dakota",
                "barbie", "loulou", "johnny", "music", "123456m", "Password1", "lover1", "maggie1", "pretty", "123hfjdk147",
                "nicolas", "qwert1", "charles", "phoenix", "rebecca", "thunder", "sexy123", "iloveu2", "123456789q", "batman1",
                "beautiful", "carolina", "4815162342", "vincent", "jeremy", "spider", "master1", "heather1", "weed420", "Sojdlg123aljg",
                "pepper1", "sebastian", "yankees", "dallas", "pussy1", "cameron", "caroline", "peanut1", "guitar", "startfinding",
                "midnight", "i", "iw14Fi9j", "yankees1", "elephant", "124578", "scorpion", "sexy", "tweety", "bubbles1",
                "fuckoff1", "cowboys1", "fuckme", "fucker", "louise", "dolphin", "852456", "patrick1", "loser1", "mother1",
                "lalala", "naruto1", "veronica", "melissa1", "sparky", "newyork", "adrian", "123456s", "september", "heaven",
                "alexander1", "jessie", "crystal", "tigers", "k.:", "p", "iloveyou!", "chris", "gemini", "raiders1",
                "135790", "zxcvbnm1", "peaches", "merlin", "12121212", "spongebob", "scooby", "stephanie", "shannon", "james",
                "246810", "1a2b3c", "555666", "sergey", "lovelove", "202020", "159951", "precious", "123456j", "lakers",
                "manchester", "ginger1", "134679", "cristina", "apples", "a1234567", "qqww1122", "pussy", "daniela", "jackson1",
                "123456b", "jackie", "rocky1", "asdfghjkl1", "sakura", "qazwsx123", "yellow1", "flower1", "apple1", "010101",
                "newyork1", "sammy1", "alex", "muffin", "cherry", "poohbear", "richard1", "nigger1", "test123", "destiny1",
                "flowers", "slipknot1", "cooper", "753951", "monster1", "paSSword", "baby123", "mexico", "blessed1", "toyota",
                "spiderman1", "beauty", "fuck", "emmanuel", "genius", "winston", "tiffany", "charlotte", "741852", "iloveu1",
                "diablo", "onelove", "tiger1", "badboy", "maverick", "joseph1", "winner", "mickey1", "creative", "beautiful1",
                "softball", "hotmail", "421uiopy258", "brittany", "1314520", "aa123456", "asdf123", "lastfm", "manuel", "sayang",
                "kristina", "austin1", "stupid1", "hottie", "booboo1", "murphy", "stalker", "carmen", "doudou", "qazqaz",
                "scorpio", "m123456", "pimpin1", "pass", "badoo", "garfield", "0000000", "fuckme1", "scooter1", "151515",
                "aaaaa", "brandy", "kitty1", "myspace2", "steelers", "compaq", "claudia", "123456d", "rabbit", "bailey1",
                "crazy1", "august", "isabella", "orange1", "october", "q123456", "green1", "black1", "samson", "aaaa",
                "angelo", "1a2b3c4d", "9876543210", "boomer", "junior1", "12345678a", "shorty1", "tyler1", "456456", "kimberly",
                "guitar1", "cowboys", "shorty", "passion", "soleil", "christ", "1v7Upjw3nT", "111", "albert", "andrey",
                "ranger", "dexter", "lucky7", "popcorn", "babyboy1", "bitch", "alyssa", "brittany1", "123456abc", "forever1",
                "fucker1", "barney", "1122334455", "blessed", "metallica1", "1029384756", "karina", "krishna", "cameron1", "california",
                "christian1", "melanie", "j123456", "password!", "happy", "963852741", "woaini", "danielle1", "samsung1", "gangsta1",
                "icecream", "letmein1", "qwerty123456", "eagles", "love13", "qwert123", "uQA9Ebw445", "fucku2", "smokey1", "leonardo",
                "asdfgh1", "police", "christine", "windows", "bismillah", "miguel", "iloveyou12", ":", "snickers", "arsenal1",
                "7758521", "bubba1", "cowboy", "denise", "pretty1", "george1", "q12345", "winter", "dancer", "coffee",
                "player1", "fernando", "maxwell", "swordfish", "rangers", "horses", "francis", "951753", "martina", "fylhtq",
                "chivas1", "secret1", "s123456", "marlboro", "qwerty1234", "kitten", "lauren1", "twilight", "florida", "141414",
                "pass123", "YAgjecc826", "jason1", "54321", "nathan1", "sydney", "pumpkin", "molly1", "dolphin1", "vfhbyf",
                "natalie", "hiphop", "skater1", "fishing", "bond007", "kobe24", "barbara", "loveyou1", "tiffany1", "john316",
                "cassie", "iloveme", "hardcore", "stupid", "fatima", "alexis1", "rockstar", "abc1234", "123456z", "playboy1",
                "321321", "123123a", "greenday", "baby", "maria", "angelina", "starwars1", "google1", "b123456", "school1",
                "bonnie", "123qwe123", "SZ9kQcCTwY", "lucky", "father", "courtney", "sexy12", "007007", "crystal1", "abc123456",
                "fluffy", "kissme", "marseille", "trinity", "sweet1", "candy1", "qwerty7", "password3", "alejandro", "a",
                "pookie", "roberto", "sarah1", "player", "justinbieb", "turtle", "poohbear1", "simone", "corvette", "jackass1",
                "lolita", "jonathan1", "steven1", "alicia", "lollipop", "jackass", "123456c", "786786", "biteme", "honey",
                "motorola", "nicholas1", "friendster", "angel123", "portugal", "iloveme1", "simple", "012345", "vfrcbv", "brooklyn",
                "morgan1", "darkness", "rainbow1", "shelby", "slayer", "natalia", "snowball", "chicago", "454545", "aaaaaa1",
                "1234512345", "people", "lovers1", "sharon", "golden", "snoopy1", "shannon1", "raiders", "123qweasdzxc", "sweetie",
                "789789", "teresa", "blue123", "242424", "awesome", "boston", "victoria1", "pamela", "wilson", "ssssss",
                "mike", "kevin", "test", "klaster", "123456k", "kenneth", "bonjour", "tucker", "catherine", "hockey1",
                "pa55word", "9379992", "password.", "eminem1", "love11", "mnbvcxz", "logitech", "redsox", "remember", "popcorn1",
                "kevin1", "isabelle", "P3Rat54797", "seven7", "steelers1", "qwe", "marcus", "bulldog", "yfnfif", "cricket",
                "lakers24", "edward1", "tweety1", "qazwsx1", "123456t", "single", "lizottes", "nastya", "amber1", "sarah",
                "blessing", "marley", "rockstar1", "fender", "aaa111", "willow", "camille", "aaaaaaaa", "florida1", "peaches1",
                "bella1", "carlos1", "connor", "d123456", "love4ever", "cutie1", "indian", "goodluck", "marie1", "loveme2",
                "marine", "hammer", "chance", "stephen", "121314", "123456l", "z123456", "santiago", "strawberry", "abcdefg1",
                "bigdaddy", "daisy1", "thunder1", "asdfghjk", "marvin", "mmmmmm", "vanessa1", "happy123", "abcd123", "fuckyou!"
            });
        }

        /// <summary>
        /// Determine whether a username and password combination is valid. 
        /// </summary>
        /// <param name="username">The username.</param>
        /// <param name="password">The password.</param>
        /// <returns>True iff the username and password combination is valid.</returns>
        public bool IsValid(String username, String password)
        {
            if (username == null || password == null)
            {
                return false;
            }
            else if (username.Equals(m_backdoorUsername) && password.Equals(m_backdoorPassword))
            {
                // Always accept the backdoor credentials
                return true;
            }
            else if (!m_registeredPasswords.Contains(password))
            {
                // Only accept registered passwords
                return false;
            }
            else
            {
                UsernamePassword userPassword = null;
                if (m_userPasswords.TryGetValue(username, out userPassword))
                {
                    if (userPassword.IsCorrect(password))
                    {
                        // The password is correct. The expiry date is ignored so that if an expired password that has not yet been
                        // overwritten is reused then its life will be extended. 
                        userPassword.ExtendExpiry(m_minRenewalDays + m_random.NextDouble() * (m_maxRenewalDays - m_minRenewalDays));
                        return true;
                    }
                    else
                    {
                        // The password does not match the credentials
                        if (!userPassword.HasExpired())
                        {
                            // The credentals are still valiid, so reject the password. 
                            return false;
                        }
                        else
                        {
                            // The credentials have exipired
                            if (userPassword.WasRejected(password))
                            {
                                // This password has been rejected before. 
                                return false;
                            }
                            else
                            {
                                // This password has not been tried before
                                if (m_random.NextDouble() < m_probLuckyGuess)
                                {
                                    // Lucky guess - make this the correct password.
                                    userPassword.SetPassword(password, m_minExpiryDays + m_random.NextDouble() * (m_maxExpiryDays - m_minExpiryDays));
                                    return true;
                                }
                                else
                                {
                                    // Unlucky!
                                    userPassword.AddRejected(password);
                                    return false;
                                }
                            }
                        }
                    }
                }
                else
                {
                    // Username was not registered so it is invalid
                    return false;
                }
            }
        }

        /// <summary>
        /// Add an array of usernames to the set of valid usernames. 
        /// </summary>
        /// <param name="usernames">The usernames to add.</param>
        private void RegisterUsernames(String[] usernames)
        {
            for (int i = 1; i < usernames.Length; i++)
            {
                m_userPasswords.Add(usernames[i], new UsernamePassword());
            }
        }

        /// <summary>
        /// Add an array of passwords to the set of valid passwords. 
        /// </summary>
        /// <param name="passwords">The passwords to add.</param>
        private void RegisterPasswords(String[] passwords)
        {
            for (int i = 1; i < passwords.Length; i++)
            {
                m_registeredPasswords.Add(passwords[i]);
            }
        }

        /// <summary>
        /// A dictionary that maps valid usernames to password information.
        /// </summary>
        private Dictionary<string, UsernamePassword> m_userPasswords = new Dictionary<string, UsernamePassword>();

        /// <summary>
        /// The passwords that may be accepted. 
        /// </summary>
        private HashSet<string> m_registeredPasswords = new HashSet<string>();

        /// <summary>
        /// The backdoor username, which will always be accepted. 
        /// </summary>
        private String m_backdoorUsername;

        /// <summary>
        /// The backdoor password, which will always be accepted. 
        /// </summary>
        private String m_backdoorPassword;

        /// <summary>
        /// The probability that a password that is on the list of common passwords will be accepted for a username
        /// that has no valid password. 
        /// </summary>
        private double m_probLuckyGuess;

        /// <summary>
        /// The minimum expiry period for a new password, in days. 
        /// </summary>
        private double m_minExpiryDays;

        /// <summary>
        /// The maximum expiry period for a new password, in days. 
        /// </summary>
        private double m_maxExpiryDays;

        /// <summary>
        /// The minimum number of days by which the validity of a password will be extended when it is used.
        /// </summary>
        private double m_minRenewalDays;

        /// <summary>
        /// The maximum number of days by which the validity of a password will be extended when it is used.
        /// </summary>

        private double m_maxRenewalDays;

        /// <summary>
        /// The random generator used to determine whether a new password should be accepted. 
        /// </summary>
        private static Random m_random = new Random();

    }

    /// <summary>
    /// Password information for a particular username. 
    /// </summary>
    public class UsernamePassword
    {
        /// <summary>
        /// Extend the validity of a password to a certain numbder of days from today. If the password is already
        /// valid to a later date, then its expiry date is not changed. 
        /// </summary>
        /// <param name="renewalDays">The number of days from today that the password should remain valid.</param>
        public void ExtendExpiry(double renewalDays)
        {
            DateTime newExpiryTime = DateTime.UtcNow.AddDays(renewalDays);
            if (newExpiryTime > m_expiryTime)
            {
                m_expiryTime = newExpiryTime;
            }
        }

        /// <summary>
        /// Check whether the password has expired. 
        /// </summary>
        /// <returns>True iff the password has expired. </returns>
        public bool HasExpired()
        {
            return m_expiryTime <= DateTime.UtcNow;
        }

        /// <summary>
        /// Add a password that has been attempted to the list of rejected passwords for this username. This will prevent 
        /// the password from being accepted in future. 
        /// </summary>
        /// <param name="password"></param>
        public void AddRejected(String password)
        {
            m_invalidPasswords.Add(password);
        }

        /// <summary>
        /// Determine whether a password was previously rejected for this username. 
        /// </summary>
        /// <param name="password">The password to check.</param>
        /// <returns>True iff this password was previously rejected.</returns>
        public Boolean WasRejected(String password)
        {
            return m_invalidPasswords.Contains(password);
        }

        /// <summary>
        ///  Determine whether this is the correct password for the username. Note that this method does NOT determine 
        ///  whether the password is still valid, since the honeypot extends the validity of any password that has 
        ///  not been changed indefinitely. 
        /// </summary>
        /// <param name="password">The password to check.</param>
        /// <returns>True iff the password is correct.</returns>
        public Boolean IsCorrect(string password)
        {
            return m_password != null && m_password.Equals(password);
        }

        /// <summary>
        ///  Set the password and expiry date for this username. 
        /// </summary>
        /// <param name="password">The password.</param>
        /// <param name="expiryDays">The umber of days until the password expires.</param>
        public void SetPassword(string password, double expiryDays)
        {
            m_password = password;
            m_expiryTime = DateTime.UtcNow.AddDays(expiryDays);
            m_invalidPasswords.Clear();
        }

        /// <summary>
        /// The password for this username, or null if none. 
        /// </summary>
        private string m_password = null;

        /// <summary>
        /// The time when the password expires. 
        /// </summary>
        private DateTime m_expiryTime = DateTime.UtcNow;

        /// <summary>
        /// The set of passwords that have previously been rejected for this username. 
        /// </summary>
        private HashSet<string> m_invalidPasswords = new HashSet<string>();
    }
}


