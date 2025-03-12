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

// Microsoft ASP.NET Core namespaces
global using Microsoft.AspNetCore.Authentication;
global using Microsoft.AspNetCore.Authentication.Cookies;
global using Microsoft.AspNetCore.Identity;
global using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
global using Microsoft.AspNetCore.Mvc;
global using Microsoft.AspNetCore.Mvc.ModelBinding;

// Entity Framework Core namespace
global using Microsoft.EntityFrameworkCore;

// AutoMapper
global using AutoMapper;

//Infrastructure
global using AnhNgocPackaging.Infrastructure.Extenstions;
global using static AnhNgocPackaging.Infrastructure.Extenstions.ServiceAttribute;
global using AnhNgocPackaging.Infrastructure.Helper;
global using AnhNgocPackaging.Domain.Constants.ErrorCode;

//Domain
global using AnhNgocPackaging.Domain.Entity;

//Presentation
global using AnhNgocPackaging.Presentation.Client.Base;