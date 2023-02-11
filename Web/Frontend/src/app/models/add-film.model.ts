export class AddFilmModel {
    constructor(
        public title: string,
        public year: number,
        public poster: string,
        public genre: string,
        public actors?: string,
        public plot?: string,
        public language?: string,
        public country?: string,
    ) {
        this.title = title;
        this.year = year;
        this.poster = poster;
        this.genre = genre;
        this.actors = actors;
        this.plot = plot;
        this.language = language;
        this.country = country;
    }
}
