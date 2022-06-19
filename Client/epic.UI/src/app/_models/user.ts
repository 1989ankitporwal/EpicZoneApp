export class User {
    constructor(
       public id: number,
       public firstName: string,
       public lastName: string,
       public userName: string,
       public password: string,
       public confirmPassword: string,
       public isActive: boolean,
       public token: string,
       public refreshToken: string,
       public roleIds: number[],
       public roles: string[]
    ){}
}
