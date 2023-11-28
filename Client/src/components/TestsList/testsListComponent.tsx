import { useEffect, useState } from "react";
import TestCard from "./testCard/testCardComponent";
import TestService from "../../Services/test.service";
import { Test } from "../types";
import "./testsListComponentStyle.css";

export default function TestsList(){
    const [userTests, setUserTests] = useState<Test[] | undefined>();

    const setNotDoneTasks = async () => {
        let response = await TestService.GetAll();
        let x = [];
        for(let i = 0; i < 10; i++)
        {
            x[i] = response[0];
        }
        setUserTests(x);
    }

    useEffect(() => {
        setNotDoneTasks();
    }, []);
    
    return(
        <div>
            {userTests != undefined && userTests.length > 0 ?
                <div className="tests-container">
                    {userTests.map(i =>
                        <TestCard key={i.id} title={i.title} category={i.category} description={i.desription}/>)}
                </div>
                : <div className="task-info">
                    <h1>You have no active tasks.<br />Let's add them.</h1>
                </div>
            }
        </div>
    )
}