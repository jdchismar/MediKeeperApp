﻿using Manager.Models;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Web;

namespace Manager
{
    public class APIManger
    {
        public ItemCollection GetItems()
        {
            ItemCollection res = new ItemCollection();
            var client = new RestClient("https://localhost:44308/");
            var request = new RestRequest("api/v1/GetMaxItems", Method.GET);
            RestResponse response = (RestResponse)client.Execute(request);

            res = Newtonsoft.Json.JsonConvert.DeserializeObject<ItemCollection>(response.Content);

            return res;
        }

        public Item ItemsByName(string ItemName)
        {
            Item res = new Item();
            var client = new RestClient("https://localhost:44308/");
            string url = string.Format("api/v1/GetMaxCostByItemName?ItemName={0}", HttpUtility.UrlEncode(ItemName));
            var request = new RestRequest(url, Method.GET);

            RestResponse response = (RestResponse)client.Execute(request);

            res = Newtonsoft.Json.JsonConvert.DeserializeObject<Item>(response.Content);

            return res;
        }

        public ItemCollection GetAllItems()
        {
            ItemCollection res = new ItemCollection();
            var client = new RestClient("https://localhost:44308/");
            var request = new RestRequest("api/v1/GetItems", Method.GET);
            RestResponse response = (RestResponse)client.Execute(request);

            res = Newtonsoft.Json.JsonConvert.DeserializeObject<ItemCollection>(response.Content);

            return res;
        }

        public bool UpdateItem(Item item)
        {
            ItemCollection res = new ItemCollection();
            var client = new RestClient("https://localhost:44308/");
            var request = new RestRequest(string.Format("api/v1/UpdateItem?ID={0}&Name={1}&Cost={2}", item.ID, item.ItemName, item.Cost), Method.POST);
            RestResponse response = (RestResponse)client.Execute(request);

            if (response.StatusCode == System.Net.HttpStatusCode.OK)
                return true;
            else
                return false;
        }

        public bool CreateItem(Item item)
        {
            ItemCollection res = new ItemCollection();
            var client = new RestClient("https://localhost:44308/");
            var request = new RestRequest(string.Format("api/v1/CreateItem?ID={0}&Name={1}&Cost={2}", item.ID, item.ItemName, item.Cost), Method.POST);
            RestResponse response = (RestResponse)client.Execute(request);

            if (response.StatusCode == System.Net.HttpStatusCode.OK)
                return true;
            else
                return false;
        }

        public bool DeleteItem(string id)
        {
            ItemCollection res = new ItemCollection();
            var client = new RestClient("https://localhost:44308/");
            var request = new RestRequest(string.Format("api/v1/DeleteItem?ID={0}", id), Method.POST);
            RestResponse response = (RestResponse)client.Execute(request);

            if (response.StatusCode == System.Net.HttpStatusCode.OK)
                return true;
            else
                return false;
        }
    }
}