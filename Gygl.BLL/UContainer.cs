﻿using Core.DAL;
using Microsoft.Practices.Unity;

namespace Gygl.BLL
{
    public class UContainer
    {
        private IUnityContainer _unityContainer;
        public UContainer()
        {
            _unityContainer = new UnityContainer();
            AddBindings();
        }

        private void AddBindings()
        {
            _unityContainer.RegisterType<Register.Manage.IUserManage, Register.Manage.UserManage>(new ContainerControlledLifetimeManager());
            _unityContainer.RegisterType<Register.Manage.IUserDetailManage, Register.Manage.UserDetailManage>(new ContainerControlledLifetimeManager());
            _unityContainer.RegisterType<Register.Manage.IRoleAuthoriseManage, Register.Manage.RoleAuthoriseManage>(new ContainerControlledLifetimeManager());
            _unityContainer.RegisterType<Register.Manage.IUserRoleManage, Register.Manage.UserRoleManage>(new ContainerControlledLifetimeManager());
        }

        public UnityDependencyResolver GetUnity
        {
            get {
                return new UnityDependencyResolver(_unityContainer);
            }
        }
    }
}