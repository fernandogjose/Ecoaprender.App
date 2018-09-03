import { Student } from "./student";

export class UserLoginResponse {
    constructor(
        public id: number, 
        public schoolId: number,
        public email: string,
        public name: string,
        public students: [Student]) { }
}