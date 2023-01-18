import React, { Component, useEffect, useState } from 'react';


const App = () => {
    const [str, setStr] = useState('bxcbxcbxcnxcn');

    useEffect(() => {
        fetch("api/GetTest")
        .then(res => res.json())
            .then(data => {

                setStr(data);
            })
            .catch(error => {
                console.log(error);
            }) 
    }, []);

    return (
        <>
            <div>{str}</div>
        </>
    )
}

export default App;