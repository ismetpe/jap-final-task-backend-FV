using Core.Interfaces;
using Core.Models.Models;
using Core.Validators;
using Database.Services;
using FluentValidation;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace movie_app_task_backend.Extensions
{
    public class AddScoped
    {
        public static void AddScopedConfig(ref IServiceCollection services)
        {
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddScoped<IMediaService, MediaService>();
            services.AddScoped<IRatingsService, RatingsService>();
            services.AddScoped<IReportsService, ReportsService>();
            services.AddScoped<IScreeningsService, ScreeningsService>();
            services.AddScoped<IActorsService, ActorsService>();
            services.AddScoped<IAuthService, AuthService>();
            services.AddScoped<IAdminsService, AdminsService>();
            services.AddScoped<IUsersService, UsersService>();

            // validation 
            services.AddScoped<IValidator<AddMovieDto>, MovieValidator>();
            services.AddScoped<IValidator<EditMovieDto>, EditMovieValidator>();
            services.AddScoped<IValidator<AddScreeningDto>, ScreeningValidator>();
            services.AddScoped<IValidator<AddPurchasedTicketDto>, BuyTicketValidator>();
            services.AddScoped<IValidator<UserLoginDto>, LoginValidator>();
            services.AddScoped<IValidator<UserRegistrationDto>, RegistrationValidator>();
        }
    }
}
