﻿using BookCave.Application.ViewModels;
using System.Threading.Tasks;


namespace BookCave.Application.Abstracts.Shop
{
    public interface IPublisherService
    {
        Task<PublisherViewModel> GetPublisherViewModelAsync();
    }
}
