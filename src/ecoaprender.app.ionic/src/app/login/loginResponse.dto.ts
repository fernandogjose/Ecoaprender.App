import { Student } from "../student/student.dto";

export class LoginResponse {
    constructor(
        public id: number, 
        public schoolId: number,
        public email: string,
        public name: string,
        public students: [Student]) { }
}