import { useEffect, useState } from "react";
import TestCard from "./testCard/testCardComponent";
import TestService from "../../Services/test.service";
import { Test } from "../types";

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
        <>
            {userTests != undefined && userTests.length > 0 ?
                <div className="task-card-wrap">
                    {userTests.map(i =>
                        <TestCard key={i.id} title={i.title} category={i.category} description={i.desription}/>)}
                </div>
                : <div className="task-info">
                    <h1>You have no active tasks.<br />Let's add them.</h1>
                </div>
            }
        </>
    )
}