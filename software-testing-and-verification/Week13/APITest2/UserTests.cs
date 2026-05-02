using FluentAssertions;
using Newtonsoft.Json;
using NUnit.Framework;
using RestApiTests.Models;
using RestSharp;
using System.Collections.Generic;
using System.Net;

namespace RestApiTests.TestFixtures
{
    [TestFixture]
    public class UserTests
    {
        private string endpointUser = "https://jsonplaceholder.typicode.com/users";
        private string endpointPost = "https://jsonplaceholder.typicode.com/posts";

        [Test]
        public void GetUsers()
        {
            RestClient client = new RestClient(endpointUser);
            RestRequest request = new RestRequest(Method.Get);

            var response = client.Execute(request);

            var responseBody = JsonConvert.DeserializeObject<List<User>>(response.Content);

            response.StatusCode.Should().Be(HttpStatusCode.OK);
            responseBody.Should().NotBeEmpty();
            responseBody.Count.Should().Be(10);
            responseBody[0].id.Should().Be(1);
        }

        [Test]
        public void CreatePost()
        {
            RestClient client = new RestClient(endpointPost);
            RestRequest request = new RestRequest(Method.Post);

            var payload = new CreatePostRequest
            {
                userId = 1,
                title = "Test Title",
                body = "Test Body"
            };

            request.AddJsonBody(payload);

            var response = client.Execute(request);

            var responseBody = JsonConvert.DeserializeObject<Post>(response.Content);

            response.StatusCode.Should().Be(HttpStatusCode.Created);
            responseBody.id.Should().BeGreaterThan(0);
        }

        [Test]
        public void GetPosts()
        {
            RestClient client = new RestClient(endpointPost);
            RestRequest request = new RestRequest(Method.Get);

            var response = client.Execute(request);

            var responseBody = JsonConvert.DeserializeObject<List<Post>>(response.Content);

            responseBody.Should().NotBeEmpty();
            responseBody.Count.Should().BeGreaterThan(1);
            responseBody[1].id.Should().BeGreaterThan(0);
        }
    }
}