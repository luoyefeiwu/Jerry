using System;
using System.IO;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace HttpWebApiHelper
{
    public class ApiHttpClientHelper
    {
        class Nested
        {
            static Nested() { }
            internal readonly static ApiHttpClientHelper instance = new ApiHttpClientHelper();
        }

        public static ApiHttpClientHelper Instance
        {
            get { return Nested.instance; }
        }
        /// <summary>
        /// GET 请求
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="url"></param>
        /// <param name="serviceUrl"></param>
        /// <param name="timeOut"></param>
        /// <returns></returns>

        public T GetWebApi<T>(string url, string serviceUrl, int? timeOut = 10) where T : class
        {
            using (HttpClient client = new HttpClient())
            {
                client.Timeout = new TimeSpan(0, 0, timeOut.HasValue ? timeOut.Value : 10);
                client.BaseAddress = new Uri(serviceUrl);
                client.DefaultRequestHeaders.Accept.Add(
                   new MediaTypeWithQualityHeaderValue("application/json"));
                var taskRes = client.GetAsync(url);
                var response = taskRes.Result;
                T result = response.Content.ReadAsAsync<T>().Result;
                return result;
            }
        }

        /// <summary>
        /// 异步GET
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="url"></param>
        /// <param name="serviceUrl"></param>
        /// <param name="timeOut"></param>
        /// <returns></returns>
        public async Task<T> GetWebApiAsync<T>(string url, string serviceUrl, int? timeOut = 10) where T : class
        {
            using (HttpClient client = new HttpClient())
            {
                client.Timeout = new TimeSpan(0, 0, timeOut.HasValue ? timeOut.Value : 10);
                client.BaseAddress = new Uri(serviceUrl);
                client.DefaultRequestHeaders.Accept.Add(
                   new MediaTypeWithQualityHeaderValue("application/json"));
                var taskRes = client.GetAsync(url);
                var response = taskRes.Result;
                T result = await response.Content.ReadAsAsync<T>();
                return result;
            }
        }


        /// <summary>
        /// POST请求
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <typeparam name="M"></typeparam>
        /// <param name="url"></param>
        /// <param name="request"></param>
        /// <param name="serviceUrl"></param>
        /// <param name="timeOut"></param>
        /// <returns></returns>

        public T PostWebApi<T, M>(string url, M request, string serviceUrl, int? timeOut = 10)
            where T : class
            where M : class
        {
            using (HttpClient client = new HttpClient())
            {
                client.Timeout = new TimeSpan(0, 0, timeOut.HasValue ? timeOut.Value : 10);
                client.BaseAddress = new Uri(serviceUrl);
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                MediaTypeFormatter jsonFormatter = new JsonMediaTypeFormatter();
                HttpContent content = new ObjectContent<M>(request, jsonFormatter);
                var taskRes = client.PostAsync(url, content);
                var response = taskRes.Result;
                T result = response.Content.ReadAsAsync<T>().Result;
                return result;
            }
        }

        /// <summary>
        /// 异步POST
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <typeparam name="M"></typeparam>
        /// <param name="url"></param>
        /// <param name="request"></param>
        /// <param name="serviceUrl"></param>
        /// <param name="timeOut"></param>
        /// <returns></returns>
        public async Task<T> PostWebApiAsync<T, M>(string url, M request, string serviceUrl, int? timeOut = 10)
            where T : class
            where M : class
        {
            using (HttpClient client = new HttpClient())
            {
                client.Timeout = new TimeSpan(0, 0, timeOut.HasValue ? timeOut.Value : 10);
                client.BaseAddress = new Uri(serviceUrl);
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                MediaTypeFormatter jsonFormatter = new JsonMediaTypeFormatter();
                HttpContent content = new ObjectContent<M>(request, jsonFormatter);
                var taskRes = client.PostAsync(url, content);
                var response = taskRes.Result;
                T result = await response.Content.ReadAsAsync<T>();
                return result;
            }
        }
        /// <summary>
        /// Delete请求
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="url"></param>
        /// <param name="serviceUrl"></param>
        /// <param name="timeOut"></param>
        /// <returns></returns>
        public T DeleteWebApi<T>(string url, string serviceUrl, int? timeOut = 10) where T : class
        {
            using (HttpClient client = new HttpClient())
            {
                client.Timeout = new TimeSpan(0, 0, timeOut.HasValue ? timeOut.Value : 10);
                client.BaseAddress = new Uri(serviceUrl);
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                var taskRes = client.DeleteAsync(url);
                var response = taskRes.Result;
                T result = response.Content.ReadAsAsync<T>().Result;
                return result;
            }
        }
        /// <summary>
        ///  异步Delete请求
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="url"></param>
        /// <param name="serviceUrl"></param>
        /// <param name="timeOut"></param>
        /// <returns></returns>
        public async Task<T> DeleteWebApiAsync<T>(string url, string serviceUrl, int? timeOut = 10)
        {
            using (HttpClient client = new HttpClient())
            {
                client.Timeout = new TimeSpan(0, 0, timeOut.HasValue ? timeOut.Value : 10);
                client.BaseAddress = new Uri(serviceUrl);
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                var taskRes = client.DeleteAsync(url);
                var response = taskRes.Result;
                T result = await response.Content.ReadAsAsync<T>();
                return result;
            }
        }

        /// <summary>
        /// 上传文件
        /// </summary>
        /// <param name="url"></param>
        /// <param name="serviceUrl"></param>
        /// <param name="stream"></param>
        /// <param name="timeOut"></param>
        /// <returns></returns>
        public string Upload(string url, string serviceUrl, FileStream stream, int? timeOut = 10)
        {
            using (HttpClient client = new HttpClient())
            {
                client.Timeout = new TimeSpan(0, 0, timeOut.HasValue ? timeOut.Value : 10);
                var content = new MultipartFormDataContent();
                content.Add(new StreamContent(stream), "image", stream.Name);
                var result = client.PostAsync(serviceUrl + "/" + url, content).Result.Content.ReadAsStringAsync().Result;
                return result;
            }
        }


    }
}
