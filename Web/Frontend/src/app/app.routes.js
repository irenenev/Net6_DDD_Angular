"use strict";
exports.__esModule = true;
exports.ROUTES = void 0;
var app_guard_1 = require("./app.guard");
var layout_nav_component_1 = require("./layouts/layout-nav/layout-nav.component");
exports.ROUTES = [
    {
        path: "",
        component: layout_nav_component_1.AppLayoutNavComponent,
        children: [
            {
                path: "",
                loadComponent: function () { return Promise.resolve().then(function () { return require("./pages/home/home.component"); }).then(function (response) { return response.AppHomeComponent; }); }
            },
            {
                path: "list",
                loadComponent: function () { return Promise.resolve().then(function () { return require("./pages/list/list.component"); }).then(function (response) { return response.AppListComponent; }); }
            },
            {
                path: "login",
                loadComponent: function () { return Promise.resolve().then(function () { return require("./pages/auth/auth.component"); }).then(function (response) { return response.AppAuthComponent; }); }
            }
        ]
    },
    {
        path: "film",
        component: layout_nav_component_1.AppLayoutNavComponent,
        children: [
            {
                path: "detail/:id",
                loadComponent: function () { return Promise.resolve().then(function () { return require("./pages/detail/detail.component"); }).then(function (response) { return response.DetailComponent; }); }
            }
        ]
    },
    {
        path: "film",
        component: layout_nav_component_1.AppLayoutNavComponent,
        canActivate: [app_guard_1.AppGuard],
        children: [
            {
                path: "add",
                loadComponent: function () { return Promise.resolve().then(function () { return require("./pages/add/add.component"); }).then(function (response) { return response.AddComponent; }); }
            },
            {
                path: "delete/:id",
                loadComponent: function () { return Promise.resolve().then(function () { return require("./pages/delete/delete.component"); }).then(function (response) { return response.DeleteComponent; }); }
            },
            {
                path: "edit/:id",
                loadComponent: function () { return Promise.resolve().then(function () { return require("./pages/edit/edit.component"); }).then(function (response) { return response.EditComponent; }); }
            }
        ]
    },
    {
        path: "**",
        redirectTo: ""
    }
];
//# sourceMappingURL=app.routes.js.map