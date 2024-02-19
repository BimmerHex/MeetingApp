namespace MeetingApp.Models
{
    public static class Repository
    {
        private static List<UserInfo> _users = new();

        static Repository()
        {
            _users.Add(new UserInfo() {
                Id = 1,
                Name = "Gökhan Zengin",
                Phone = "+905322902834",
                Email = "contact@vintagegamestudio.com",
                WillAttend = true
            });

            _users.Add(new UserInfo() {
                Id = 2,
                Name = "Fuat Kanbur",
                Phone = "+905461548498",
                Email = "fuatkanbur@gmail.com",
                WillAttend = false
            });

            _users.Add(new UserInfo() {
                Id = 3,
                Name = "Güllü Kanbur",
                Phone = "+905325458410",
                Email = "gullukanbur@gmail.com",
                WillAttend = true
            });
        }

        public static List<UserInfo> Users {
            get {
                return _users;
            }
        }

        public static void AddUser(UserInfo userInfo)
        {
            userInfo.Id = Users.Count + 1;
            _users.Add(userInfo);
        }

        public static UserInfo? GetUserById(int id)
        {
            return _users.FirstOrDefault(user => user.Id == id);
        }
    }
}