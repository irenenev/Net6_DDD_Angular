"use strict";(self.webpackChunkfrontend=self.webpackChunkfrontend||[]).push([[799],{5799:(h,l,o)=>{o.r(l),o.d(l,{AppHomeComponent:()=>u});class p{id;title;year;poster;genre}var a=o(7352),s=o(8692),t=o(6985),d=o(7556);function g(r,i){if(1&r&&(t.TgZ(0,"div",7)(1,"button",8),t._uU(2,"Edit"),t.qZA(),t.TgZ(3,"button",8),t._uU(4,"Delete"),t.qZA()()),2&r){const e=t.oxw();t.xp6(1),t.MGl("routerLink","/film/edit/",e.Film.id,""),t.xp6(2),t.MGl("routerLink","/film/delete/",e.Film.id,"")}}class c{appAuthService;Film=new p;constructor(i){this.appAuthService=i}userLoggedIn=!1;ngOnInit(){this.userLoggedIn=this.appAuthService.authenticated()}static \u0275fac=function(e){return new(e||c)(t.Y36(d.K))};static \u0275cmp=t.Xpm({type:c,selectors:[["app-img-card"]],inputs:{Film:"Film"},standalone:!0,features:[t.jDz],decls:11,vars:7,consts:[[1,"uk-card","uk-card-default"],[1,"uk-card-header"],[1,"uk-card-body","uk-padding-remove","card-img-wrapper"],[3,"routerLink"],[1,"uk-width-1-1",3,"src","alt"],["class","uk-button-group uk-width-1-1 uk-align-center member-icons animate",4,"ngIf"],[1,"uk-card-footer"],[1,"uk-button-group","uk-width-1-1","uk-align-center","member-icons","animate"],[1,"uk-button","uk-button-secondary",3,"routerLink"]],template:function(e,n){1&e&&(t.TgZ(0,"div",0)(1,"div",1)(2,"h5"),t._uU(3),t.qZA()(),t.TgZ(4,"div",2)(5,"a",3),t._UZ(6,"img",4),t.qZA(),t.YNc(7,g,5,2,"div",5),t.qZA(),t.TgZ(8,"div",6)(9,"h6"),t._uU(10),t.qZA()()()),2&e&&(t.xp6(3),t.Oqu(n.Film.title),t.xp6(2),t.MGl("routerLink","/film/detail/",n.Film.id,""),t.xp6(1),t.Q6J("src",n.Film.poster,t.LSH)("alt",n.Film.title),t.xp6(1),t.Q6J("ngIf",n.userLoggedIn),t.xp6(3),t.AsE("",n.Film.genre," - ",n.Film.year,""))},dependencies:[a.Bz,a.rH,s.ez,s.O5],styles:[".card-img-wrapper[_ngcontent-%COMP%]{overflow:hidden;position:relative}.uk-card[_ngcontent-%COMP%]:hover   img[_ngcontent-%COMP%]{transform:scale(1.2);transition-duration:.5s;transition-timing-function:ease-out;opacity:.7}.uk-card[_ngcontent-%COMP%]   img[_ngcontent-%COMP%]{transform:scale(1);transition-duration:.5s;transition-timing-function:ease-out;max-width:100%;height:auto;overflow:hidden}.member-icons[_ngcontent-%COMP%]{position:absolute;bottom:-10%;left:0;right:0;margin-right:auto;margin-left:auto;opacity:0}.card-img-wrapper[_ngcontent-%COMP%]:hover   .member-icons[_ngcontent-%COMP%]{bottom:0;opacity:1}.animate[_ngcontent-%COMP%]{transition:all .3s ease-in-out}"]})}var f=o(2515);function v(r,i){if(1&r&&(t.TgZ(0,"div"),t._UZ(1,"app-img-card",2),t.qZA()),2&r){const e=i.$implicit;t.xp6(1),t.Q6J("Film",e)}}class m{filmService;FilmArr=[];constructor(i){this.filmService=i}ngOnInit(){this.filmService.list().subscribe(i=>this.FilmArr=i)}static \u0275fac=function(e){return new(e||m)(t.Y36(f.O))};static \u0275cmp=t.Xpm({type:m,selectors:[["app-img-list"]],standalone:!0,features:[t.jDz],decls:2,vars:1,consts:[["uk-grid","",1,"uk-grid-match","uk-grid-row-large","uk-child-width-1-3@s","uk-text-center"],[4,"ngFor","ngForOf"],[3,"Film"]],template:function(e,n){1&e&&(t.TgZ(0,"div",0),t.YNc(1,v,2,1,"div",1),t.qZA()),2&e&&(t.xp6(1),t.Q6J("ngForOf",n.FilmArr))},dependencies:[c,s.ez,s.sg,a.Bz],encapsulation:2})}class u{static \u0275fac=function(e){return new(e||u)};static \u0275cmp=t.Xpm({type:u,selectors:[["app-home"]],standalone:!0,features:[t.jDz],decls:2,vars:0,template:function(e,n){1&e&&(t.TgZ(0,"div"),t._UZ(1,"app-img-list"),t.qZA())},dependencies:[a.Bz,m],encapsulation:2})}}}]);