class Person {
    firstName:string;
    lastName:string;
    height:number;
    skill:string[];
  
    constructor(firstName:string, lastName:string, height:number, skill:string[] = ["JavaScript", "TypeScript", "React", "NodeJS"]){
        this.firstName = firstName;
        this.lastName = lastName;
        this.height = height;
        this.skill = skill;
    }

    displaySkills():string[]{
        return this.skill;
    }

    greetUser():string{
        return "Hello and welcome to Typescipt";
    }  
}

// const person1 = new Person("Nikhil", "Shah", 175);
// const person2 = new Person("Jane", "Mary", 160);

// console.log(person1.greetUser());
// console.log(person2.greetUser());

// console.log("Hello " + person1.firstName + " " + person1.lastName);
// console.log("Hello " + person2.firstName + " " + person2.lastName);

// console.log(person1.displaySkills());



