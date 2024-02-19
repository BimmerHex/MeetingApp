namespace MeetingApp.Models
{
    public static class Repository
    {
        private static List<UserInfo> _users = new();

        static Repository()
        {
            _users.Add(new UserInfo() {
                Name = "Gökhan Zengin",
                Phone = "+905322902834",
                Email = "contact@vintagegamestudio.com",
                WillAttend = true
            });

            _users.Add(new UserInfo() {
                Name = "Fuat Kanbur",
                Phone = "+905461548498",
                Email = "fuatkanbur@gmail.com",
                WillAttend = false
            });

            _users.Add(new UserInfo() {
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
            _users.Add(userInfo);
        }
    }
}