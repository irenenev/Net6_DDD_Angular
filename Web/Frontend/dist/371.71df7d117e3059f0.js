"use strict";(self.webpackChunkfrontend=self.webpackChunkfrontend||[]).push([[371],{1371:(d,l,e)=>{e.r(l),e.d(l,{DetailComponent:()=>r});var o=e(2080),s=e(7352),i=e(6985),a=e(2515);class r{route;filmService;id;Film=new o.G;constructor(u,n){this.route=u,this.filmService=n,this.route.params.subscribe(t=>this.id=t.id)}ngOnInit(){this.filmService.get(this.id).subscribe(u=>this.Film=u)}static \u0275fac=function(n){return new(n||r)(i.Y36(s.gz),i.Y36(a.O))};static \u0275cmp=i.Xpm({type:r,selectors:[["app-detail"]],standalone:!0,features:[i.jDz],decls:28,vars:9,consts:[[1,"uk-margin"],[1,"uk-width-1-4",3,"src","alt"],[1,"uk-button-group"],["routerLink","/",1,"uk-button","uk-button-primary","uk-margin-right"],["routerLink","/list",1,"uk-button","uk-button-primary"]],template:function(n,t){1&n&&(i.TgZ(0,"div",0)(1,"h5"),i._uU(2),i.qZA()(),i.TgZ(3,"div",0)(4,"div"),i._uU(5),i.qZA()(),i.TgZ(6,"div",0),i._UZ(7,"img",1),i.qZA(),i.TgZ(8,"div",0)(9,"div"),i._uU(10),i.qZA()(),i.TgZ(11,"div",0)(12,"div"),i._uU(13),i.qZA()(),i.TgZ(14,"div",0)(15,"div"),i._uU(16),i.qZA()(),i.TgZ(17,"div",0)(18,"div"),i._uU(19),i.qZA()(),i.TgZ(20,"div",0)(21,"div"),i._uU(22),i.qZA()(),i.TgZ(23,"div",2)(24,"button",3),i._uU(25,"Home"),i.qZA(),i.TgZ(26,"button",4),i._uU(27,"List"),i.qZA()()),2&n&&(i.xp6(2),i.Oqu(t.Film.title),i.xp6(3),i.hij("",t.Film.year," year"),i.xp6(2),i.Q6J("src",t.Film.poster,i.LSH)("alt",t.Film.title),i.xp6(3),i.hij("Genre: ",t.Film.genre,""),i.xp6(3),i.hij("Actors: ",t.Film.actors,""),i.xp6(3),i.hij("Description: ",t.Film.plot,""),i.xp6(3),i.hij("Language: ",t.Film.language,""),i.xp6(3),i.hij("Country: ",t.Film.country,""))},dependencies:[s.Bz,s.rH],encapsulation:2})}}}]);