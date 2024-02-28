using ION_ProjectExtractLibrary;
using ION_ProjectExtractLibrary.Processors;


await ApiHelper.InitializeClientAsync();
//var test = AzureKeyvault.GetSecret();
//var testing = await IonAuthenticate.GetTokenAsync();

//var dataFlows = await Connect_DataFlowProcesser.GetInfo();
//var dataFlow = await Connect_DataFlowProcesser.GetInfo("Kardex_Handle_PickResult_Ack");
//var dataflowData = await Connect_DataFlowProcesser.GetJson("Kardex_Handle_PickResult_Ack");

//var gitHubRepos = await GitHub_RepositoryProcessor.GetInfo();

//var gitHubBranches = await GitHub_RepositoryProcessor.GetBranches("gregstacy", "APITest");

//string owner = "gregstacy";
//string repo = "APITest";
//string path = "ION_Connect_DataFlows/DW_EH_lnsa4_tdsls408.JSON";
//string message = "Test DW_EH_lnsa4_tdsls413 inserted from web tools";
//string content = "{\r\n  \"flowPart\": {\r\n    \"_type\": \"flowPartContainer\",\r\n    \"sequenceNumber\": 0,\r\n    \"runtimeProcessId\": \"ec44f02a-2b90-4b7e-b726-f7d732b7c234\",\r\n    \"flowPartContainerType\": \"START_END\",\r\n    \"flowParts\": [\r\n      {\r\n        \"_type\": \"flowPartContainer\",\r\n        \"sequenceNumber\": 0,\r\n        \"runtimeProcessId\": \"22e26418-0851-4112-af6e-dd065e6b4f03\",\r\n        \"flowPartContainerType\": \"SEQUENTIAL_FLOW\",\r\n        \"flowParts\": [\r\n          {\r\n            \"_type\": \"fileActivity\",\r\n            \"sequenceNumber\": 1,\r\n            \"runtimeProcessId\": \"82cb35e9-c5f1-4fe6-811f-038d7f7a84d6\",\r\n            \"name\": \"GrandCentral\",\r\n            \"activityType\": \"FILE\",\r\n            \"activityDocuments\": [],\r\n            \"fileConnectionPoint\": \"EC_DataStream_EventHub\"\r\n          },\r\n          {\r\n            \"_type\": \"applicationActivity\",\r\n            \"sequenceNumber\": 0,\r\n            \"runtimeProcessId\": \"95e07870-a414-44a0-a00f-ebb7be1dff02\",\r\n            \"name\": \"ln01_ims\",\r\n            \"activityType\": \"APPLICATION\",\r\n            \"activityDocuments\": [\r\n              {\r\n                \"noun\": \"LN_tdsls413\",\r\n                \"verb\": \"\",\r\n                \"documentType\": \"JSON\"\r\n              }\r\n            ],\r\n            \"applicationConnectionPoints\": \"ln01_ims\"\r\n          }\r\n        ]\r\n      }\r\n    ]\r\n  },\r\n  \"name\": \"DW_EH_lnsa4_tdsls413\",\r\n  \"description\": \"Data from tables:\\nLN_tdsls413\",\r\n  \"type\": \"DOCUMENT_FLOW\",\r\n  \"documentFlowStatus\": \"INACTIVE\",\r\n  \"lastUpdatedBy\": \"Greg Stacy\",\r\n  \"lastUpdatedOn\": \"2023-01-04T15:43:42.830Z\",\r\n  \"protectOnExport\": false,\r\n  \"runtimeProcessId\": \"53917951-e893-451b-99e9-bcf3f06158cc\",\r\n  \"protected\": false\r\n}";
//string branch = "devl";

//var responce = await GitHub_RepositoryProcessor.CreateOrUpdateFiles(owner, repo, path, message, content, branch);

//var responce = await GitHub_RepositoryProcessor.GetTree(owner, repo, branch, 10);

//var DataCatalogObjects = await DataCatalog_ObjectSchemasProcessor.GetInfo();

var DataCatalogObjects = await DataCatalog_ObjectSchemasProcessor.GetPayload("Sync.Kardex_CycleCount_XML");

Console.WriteLine("Hello, World!");
