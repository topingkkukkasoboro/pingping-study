import React from 'react';
import { Link } from 'react-router-dom';

const BasicLayout = ({children}) => {
    return (  
        <>
        <div className="App-header">
            <h1>Header</h1>
            <div className='App-test'>
                <h1>dodo</h1> 
            </div>
            <div>{children}</div>
            </div>
            <div className="App-footer">
            <h1>Footer</h1>
            <Link to="/">Home</Link>
            <Link to="/about">About</Link>
            <Link to="/contact">Contact</Link>
            </div>
        </>
    );
}
 
export default BasicLayout;