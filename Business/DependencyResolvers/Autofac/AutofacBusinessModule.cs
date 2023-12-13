using Autofac;
using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            //singleton lifetime
            builder.RegisterType<RecipeManager>().As<IRecipeService>().SingleInstance();
            builder.RegisterType<EfRecipeDal>().As<IRecipeDal>().SingleInstance();

            builder.RegisterType<IngredientManager>().As<IIngredientService>().SingleInstance();
            builder.RegisterType<EfIngredientDal>().As<IIngredientDal>().SingleInstance();

            builder.RegisterType<CuisineManager>().As<ICuisineService>().SingleInstance();
            builder.RegisterType<EfCuisineDal>().As<ICuisineDal>().SingleInstance();

            builder.RegisterType<UserManager>().As<IUserService>().SingleInstance();
            builder.RegisterType<EfUserDal>().As<IUserDal>().SingleInstance();
        }
    }
}
