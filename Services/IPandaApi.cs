﻿using RestSharp;

namespace EsportsCalendar.Services
{
    public interface IPandaApi
    {
        RestClient GetClient();
    }
}