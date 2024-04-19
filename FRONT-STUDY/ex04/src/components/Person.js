import React, { useState } from 'react';
import axios from 'axios';

import Button from '@mui/material/Button';

const getPerson = async () => {
    console.log('getperson');
    const id = parseInt(Math.random() * 3 + 1);
    const result = await axios.get(`http://localhost:8080/person/one/${id}`);
    console.log(result);
    return result.data;
}
const Person = ({name:personname,age:as}) => {
    console.log('person');
    const [age, setAge] = useState(as);
    const [name, setName] = useState(personname);

    const addAge = () =>{
        setAge(age + 1);
    }
    const subAge = () =>{
        setAge(age -1);
    }
    return (
    <>
    <h1>Person</h1>
    <h2>이름={name}</h2>
    <h2>나이={age}</h2>
    <Button onClick={addAge} variant='contained'>나이증가</Button>
    <Button onClick={subAge} variant='contained'>나이감소</Button>
    <button onClick={async()=>{
        const data = await getPerson();
        setAge(data.age);
        setName(data.name);
    }}>가져오기</button>
    </>
    );
}
 
export default Person;