// System namespaces
global using System;
global using System.ComponentModel;
global using System.ComponentModel.DataAnnotations;
global using System.Diagnostics;
global using System.Linq.Expressions;
global using System.Net;
global using System.Reflection;
global using System.Security.Claims;
global using System.Security.Cryptography;
global using System.Text;
global using System.Text.Json;
global using System.Text.Json.Serialization;
global using System.Web;
//Mongo
global using MongoDB.Bson.Serialization.Attributes;
global using MongoDB.Bson;
global using MongoDB.Driver;


// Microsoft ASP.NET Core namespaces
global using Microsoft.AspNetCore.Authentication;
global using Microsoft.AspNetCore.Authentication.Cookies;
global using Microsoft.AspNetCore.Identity;
global using Microsoft.AspNetCore.Mvc;
global using Microsoft.AspNetCore.Mvc.ModelBinding;


// AutoMapper
global using AutoMapper;

//Infrastructure
global using AnhNgocPackaging.Infrastructure.Extenstions;
global using static AnhNgocPackaging.Infrastructure.Extenstions.ServiceAttribute;
global using AnhNgocPackaging.Infrastructure.Helper;
global using AnhNgocPackaging.Domain.Constants.ErrorCode;
global using AnhNgocPackaging.Infrastructure.MongoDb;
//Domain
global using AnhNgocPackaging.Domain.Entity;
global using AnhNgocPackaging.Domain.Constants.Component;
global using AnhNgocPackaging.Domain.Constants.Product;
//Presentation
global using AnhNgocPackaging.Presentation.Client.Base;
global using AnhNgocPackaging.Presentation.Admin.Base;
global using AnhNgocPackaging.Presentation.Dto.Param;
global using AnhNgocPackaging.Presentation.Dto.Result;
global using AnhNgocPackaging.Presentation.Client.ViewComponentOnline.Policy.Dto.Result;
global using AnhNgocPackaging.Presentation.Client.ViewComponentOnline.Banner.Dto.Result;
global using AnhNgocPackaging.Presentation.Client.ViewComponentOnline.Dto.Result;
global using AnhNgocPackaging.Presentation.Client.ViewComponentOnline.Product.Dto.Result;
global using AnhNgocPackaging.Presentation.Client.ViewComponentOnline.ProductCategory.Dto.Result;
//Application
global using AnhNgocPackaging.Application.UseCase.ViewComponentUseCase;

