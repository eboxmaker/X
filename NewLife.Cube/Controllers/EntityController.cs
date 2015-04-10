﻿using System;
using System.ComponentModel;
using System.Web.Mvc;
using NewLife.Cube.Filters;
using XCode;
using XCode.Web;

namespace NewLife.Cube.Controllers
{
    /// <summary>实体控制器基类</summary>
    /// <typeparam name="TEntity"></typeparam>
    [EntityAuthorize]
    public class EntityController<TEntity> : Controller where TEntity : Entity<TEntity>, new()
    {
        public EntityController()
        {
            ViewBag.Title = Entity<TEntity>.Meta.Table.Description + "管理";
        }

        /// <summary>数据列表首页</summary>
        /// <returns></returns>
        [DisplayName("数据列表")]
        public virtual ActionResult Index()
        {
            ViewBag.Grid = new EntityGrid(Entity<TEntity>.Meta.Factory);

            var list = Entity<TEntity>.FindAllWithCache();

            return View(list);
        }

        /// <summary>删除</summary>
        /// <param name="id"></param>
        /// <returns></returns>
        //[HttpPost]
        [DisplayName("删除")]
        public virtual ActionResult Delete(String id)
        {
            var entity = Entity<TEntity>.FindByKey(id);
            entity.Delete();

            return RedirectToAction("Index");
        }

        /// <summary>表单，添加/修改</summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [DisplayName("添加数据")]
        public virtual ActionResult Form(String id)
        {
            var entity = Entity<TEntity>.FindByKeyForEdit(id);

            return View(entity);
        }

        /// <summary>保存</summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        [HttpPost]
        [DisplayName("保存")]
        public virtual ActionResult Save(TEntity entity)
        {
            entity.Save();

            ViewBag.StatusMessage = "保存成功！";

            return View("Form", entity);
            //return RedirectToAction("Form/" + entity[Entity<TEntity>.Meta.Unique.Name]);
        }
    }
}