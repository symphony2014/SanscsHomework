﻿
using System;
using System.Net.Http;
using System.Web.Http.Controllers;
using System.Web.Http.Dispatcher;
using Microsoft.Practices.Unity;
using Sanscs.Homework.Service;
namespace Sanscs.Homework.WebAPI.App_Start
{
    public class UnityActivator : IHttpControllerActivator
    {
        private readonly IUnityContainer container;

        public UnityActivator(IUnityContainer container)
        {
            this.container = container;
        }

        public IHttpController Create(
            HttpRequestMessage request,
            HttpControllerDescriptor controllerDescriptor,
            Type controllerType)
        {
            var controller =
                (IHttpController)this.container.Resolve(controllerType);

            //request.RegisterForDispose(
            //    new Release(
            //        () => this.container.Release(controller)));

            return controller;
        }

        private class Release : IDisposable
        {
            private readonly Action release;

            public Release(Action release)
            {
                this.release = release;
            }

            public void Dispose()
            {
                this.release();
            }
        }

    }
}