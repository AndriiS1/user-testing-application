import { useEffect, useState } from "react";
import TestCard from "./testCard/testCardComponent";
import TestService from "../../Services/test.service";
import { Test } from "../types";
import "./testsListComponentStyle.css";

export default function TestsList(){
    const [userTests, setUserTests] = useState<Test[] | undefined>();

    const setNotDoneTasks = async () => {
        let response = await TestService.GetAll();
        setUserTests(response);
    }

    useEffect(() => {
        setNotDoneTasks();
    }, []);
    
    return(
        <div>
            {userTests != undefined && userTests.length > 0 ?
                <div className="tests-container">
                    {userTests.map(i =>
                        <TestCard key={i.id} title={i.title} category={i.category} description={i.description}/>)}
                </div>
                : <div className="task-info">
                    <h1>Here is no tests.</h1>
                </div>
            }
        </div>
    )
}