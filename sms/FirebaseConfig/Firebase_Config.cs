using FireSharp.Interfaces;

namespace sms.FirebaseConfig
{
    public static class FirebaseConfig
    {
        public static readonly IFirebaseConfig Config = new FireSharp.Config.FirebaseConfig
        {
            AuthSecret = "knSrEdjr4LxYi84J6N7vMCuV5iNbLv35wqyuZ9B1",
            BasePath = "https://school-management-system-1eec4.firebaseio.com/"
        };
    }
}