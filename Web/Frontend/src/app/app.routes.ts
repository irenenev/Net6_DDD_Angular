import { Routes } from "@angular/router";
import { AppGuard } from "./app.guard";
//import { AppLayoutComponent } from "./layouts/layout/layout.component";
import { AppLayoutNavComponent } from "./layouts/layout-nav/layout-nav.component";

export const ROUTES: Routes = [
    {
        path: "",
        component: AppLayoutNavComponent,
        children: [
            {
                path: "",
                loadComponent: () => import("./pages/home/home.component")
                    .then((response) => response.AppHomeComponent)
            },
            {
                path: "list",
                loadComponent: () => import("./pages/list/list.component")
                    .then((response) => response.AppListComponent)
            },
            {
                path: "login",
                loadComponent: () => import("./pages/auth/auth.component")
                    .then((response) => response.AppAuthComponent)
            }
        ]
    },
    {
        path: "film",
        component: AppLayoutNavComponent,
        children: [
            {
                path: "detail/:id",
                loadComponent: () => import("./pages/detail/detail.component")
                    .then((response) => response.DetailComponent)
            }
        ]
    },
    {
        path: "film",
        component: AppLayoutNavComponent,
        canActivate: [AppGuard],
        children: [
            {
                path: "add",
                loadComponent: () => import("./pages/add/add.component")
                    .then((response) => response.AddComponent)
            },
            {
                path: "delete/:id",
                loadComponent: () => import("./pages/delete/delete.component")
                    .then((response) => response.DeleteComponent)
            },
            {
                path: "edit/:id",
                loadComponent: () => import("./pages/edit/edit.component")
                    .then((response) => response.EditComponent)
            }
        ]
    },
    {
        path: "**",
        redirectTo: ""
    }
];
