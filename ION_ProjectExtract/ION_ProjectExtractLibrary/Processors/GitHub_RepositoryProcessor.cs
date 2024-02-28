using ION_ProjectExtractLibrary.Models;
using Newtonsoft.Json;
using System.Net.Http;

namespace ION_ProjectExtractLibrary.Processors
{
    public class GitHub_RepositoryProcessor
    {
        public static async Task<List<GitHubRepoModel>> GetInfo()
        {
            using HttpResponseMessage response = await ApiHelper.ApiClient.GetAsync(
                "https://mingle-ionapi.inforcloudsuite.com/JBTC_DEV/CustomerApi/GitHubAPI/github/user/repos");
            var resultString = await response.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<List<GitHubRepoModel>>(resultString);

            if (result != null)
            {
                return result;
            }
            else
            {
                return new List<GitHubRepoModel>();
            }
        }

        public static async Task<List<GitHubBranchModel>> GetBranches(string Owner, string Repo)
        {
            using HttpResponseMessage response = await ApiHelper.ApiClient.GetAsync(
                    "https://mingle-ionapi.inforcloudsuite.com/JBTC_DEV/CustomerApi/GitHubAPI/github/repos/" + Owner + "/" + Repo + "/branches");
            var resultString = await response.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<List<GitHubBranchModel>>(resultString);

            if (result != null)
            {
                return result;
            }
            else
            {
                return new List<GitHubBranchModel>();
            }
        }

        public static async Task<GitHubRepoTreesModel> GetTree(string Owner, string Repo, string Branch, int Recursive)
        {
            using HttpResponseMessage response = await ApiHelper.ApiClient.GetAsync(
                    "https://mingle-ionapi.inforcloudsuite.com/JBTC_DEV/CustomerApi/GitHubAPI/github/repos/" + Owner + "/" + Repo + "/git/trees/" + Branch + "?recursive=" + Recursive.ToString());
            var resultString = await response.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject <GitHubRepoTreesModel> (resultString);

            if (result != null)
            {
                return result;
            }
            else 
            { 
                return new GitHubRepoTreesModel(); 
            }
        }

        public static async Task<GitHubCreateOrUpdateFileResponseModel> CreateOrUpdateFiles(string Owner, string Repo, string Path, string Message, string Content, string Branch)
        {
            var tree = await GitHub_RepositoryProcessor.GetTree(Owner, Repo, Branch, 100);
            List<GitHubTreeModel> treeResultList = new();

            if (tree != null)
            {
                if (tree.Tree != null)
                {
                    treeResultList = tree.Tree.Where(x => x.Path == Path).ToList();
                }
            }

            
            CreateOrUpdatePayloadModel payload = new();
            string base64Content = Base64.Encode(Content);

            payload.message = Message;
            payload.content = base64Content;
            payload.branch = Branch;

            if (treeResultList.Count > 0)
            {
                payload.sha = treeResultList[0].Sha;
            }

            string jsonPayload = JsonConvert.SerializeObject(payload);
            var stringContent = new StringContent(jsonPayload);

            using HttpResponseMessage response = await ApiHelper.ApiClient.PutAsJsonAsync<CreateOrUpdatePayloadModel>(
                    "https://mingle-ionapi.inforcloudsuite.com/JBTC_DEV/CustomerApi/GitHubAPI/github/repos/" + Owner + "/" + Repo + "/contents/" + Path, payload);
            var resultString = await response.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<GitHubCreateOrUpdateFileResponseModel>(resultString);

            if (result != null)
            {
                return result;
            }
            else
            {
                return new GitHubCreateOrUpdateFileResponseModel();
            }
        }
    }
}
