namespace Shop.Common.Models
{
    using Newtonsoft.Json;
    using System;

    public class Product
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("price")]
        public int Price { get; set; }

        [JsonProperty("imageUrl")]
        public string ImageUrl { get; set; }

        [JsonProperty("lastPurchase")]
        public DateTime LastPurchase { get; set; }

        [JsonProperty("lastSale")]
        public DateTime LastSale { get; set; }

        [JsonProperty("isAvailabe")]
        public bool IsAvailabe { get; set; }

        [JsonProperty("stock")]
        public int Stock { get; set; }

        [JsonProperty("user")]
        public User User { get; set; }

        [JsonProperty("imageFullPath")]
        public string ImageFullPath { get; set; }
    }
}
