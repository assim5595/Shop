﻿namespace Shop.UIFroms.ViewModels
{
    public class MainViewModel
    {
        public LoginViewModel Login { get; set; }
        public ProductsViewModel Products { get; set; }

        public MainViewModel()
        {
            this.Login = new LoginViewModel();
        }

    }
}
