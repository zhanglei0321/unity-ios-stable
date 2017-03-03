#if UNITY_IPHONE
    using UnityEngine;
    using System;
    using System.Collections;
    using ElvaJSON;

    namespace elva{
    	public class ElvaIOS{

    		[DllImport ("__Internal")]
			private static extern void elvaInit (string appKey,string domain,string appId);
			[DllImport ("__Internal")]
			private static extern void elvaShowElva (string playerName,string playerUid,string serverId,string playerParseId,string showConversationFlag);
			[DllImport ("__Internal")]
			private static extern void elvaShowElvaWithConfig (string playerName,string playerUid,string serverId,string playerParseId,string showConversationFlag,string jsonConfig);
			[DllImport ("__Internal")]
			private static extern void elvaShowConversation (string playerUid,string serverId);
			[DllImport ("__Internal")]
			private static extern void elvaShowConversationWithConfig (string playerUid,string serverId,string jsonConfig);
			[DllImport ("__Internal")]
			private static extern void elvaShowSingleFAQ (string faqId);
			[DllImport ("__Internal")]
			private static extern void elvaShowSingleFAQWithConfig (string faqId,string jsonConfig);
			[DllImport ("__Internal")]
			private static extern void elvaShowFAQSection (string sectionPublishId);
			[DllImport ("__Internal")]
			private static extern void elvaShowFAQSectionWithConfig (string sectionPublishId,string jsonConfig);
			[DllImport ("__Internal")]
			private static extern void elvaShowFAQList ();
			[DllImport ("__Internal")]
			private static extern void elvaShowFAQListWithConfig (string jsonConfig);
			[DllImport ("__Internal")]
			private static extern void elvaSetName (string gameName);
			[DllImport ("__Internal")]
			private static extern void elvaSetUserId (string playerUid);
			[DllImport ("__Internal")]
			private static extern void elvaSetServerId (string serverId);
			[DllImport ("__Internal")]
			private static extern void elvaSetUserName (string playerName);
			[DllImport ("__Internal")]
			private static extern void elvaSetSDKLanguage(string sdkLanguage);
			[DllImport ("__Internal")]
			private static extern void elvaSetUseDevice ();
			[DllImport ("__Internal")]
			private static extern void elvaSetEvaluateStar (int star);

			public void init(string appKey,string domain,string appId){
            	elvaInit(appKey,domain,appId);
            }
            public void showElva(string playerName,string playerUid,string serverId,string playerParseId,string showConversationFlag){
            	elvaShowElva(playerName,playerUid,serverId,playerParseId,showConversationFlag);
            }
		    public void showElva(string playerName,string playerUid,string serverId,string playerParseId,string showConversationFlag,Dictionary<string,object> config){
		    	elvaShowElvaWithConfig(playerName,playerUid,serverId,playerParseId,showConversationFlag,Json.Serialize(configMap));
		    }
		    public void showConversation(string playerUid,string serverId){//请优先实现setUserName接口
				elvaShowConversation(playerUid,serverId);
		    }
		    public void showConversation(string playerUid,string serverId,Dictionary<string,object> config){
		    	elvaShowConversationWithConfig(playerUid,serverId,Json.Serialize(configMap));
		    }
		    public void showSingleFAQ(string faqId){
				elvaShowSingleFAQ(faqId);
		    }
		    public void showSingleFAQ(string faqId,Dictionary<string,object> config){
		    	elvaShowSingleFAQWithConfig(faqId,Json.Serialize(configMap));
		    }
		    public void showFAQSection(string sectionPublishId){
				elvaShowFAQSection(sectionPublishId);
		    }
		    public void showFAQSection(string sectionPublishId,Dictionary<string,object> config){
				elvaShowFAQSectionWithConfig(sectionPublishId),Json.Serialize(configMap);
		    }
		    public void showFAQList(){
				elvaShowFAQList();
		    }
		    public void showFAQList(Dictionary<string,object> config){
				elvaShowFAQListWithConfig(,Json.Serialize(configMap));
		    }
		    public void setName(string gameName){
				elvaSetName(gameName);
		    }
		    
		    public void setUserId(string playerUid){//自助服务，在showFAQ之前调用
				elvaSetUserId(playerUid);
		    }
		    public void setServerId(string serverId){//自助服务，在showFAQ之前调用
				elvaSetServerId(serverId);
		    }
		    public void setUserName(string playerName){//在需要的接口之前调用，建议游戏刚进入就默认调用
				elvaSetUserName(playerName);
		    }
		    public void setSDKLanguage(string sdkLanguage){
		        elvaSetSDKLanguage(sdkLanguage);
		    }

		    public void setUseDevice(){
		        elvaSetUseDevice();
		    }

		    public void setEvaluateStar(int star){
		        elvaSetEvaluateStar();
		    }
		    
    	}

    }
#endif