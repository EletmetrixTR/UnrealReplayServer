/*
The MIT License (MIT)
Copyright (c) 2021 Henning Thoele
*/

namespace UnrealReplayServer.Connectors
{
    public class UserAgentDetails
    {
        public string[] AllowedUserAgents { get; set; }

        public bool bUseUserAgentFilter { get; set; }
    }

    public class MongoDB
    {
        public string MongoDBConnection { get; set; }

        public string MongoDBDatabaseName { get; set; }

        public bool bUseEnvVariable_Connection { get; set; }

        public bool bUseEnvVariable_DatabaseName { get; set; }
    }

    public class ApplicationDefaults
    {
        public MongoDB MongoDB { get; set; }

        public bool bLiveStreamMode { get; set; }

        public int HeartbeatCheckTime { get; set; }

        public int TimeoutOfLiveSession { get; set; }

        public bool bUseAuthorizationHeader { get; set; }

        public string AuthorizationHeaderValue { get; set; }

        public UserAgentDetails UserAgentDetails { get; set; }
    }
}