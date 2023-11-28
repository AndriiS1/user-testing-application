import { useEffect, useState } from "react";
import TestCard from "./testCard/testCardComponent";
import TestService from "../../Services/test.service";
import { CompletedTestDto, Test } from "../types";
import "./testsListComponentStyle.css";

export default function TestsList() {
    const [userTests, setUserTests] = useState<Test[] | undefined>();
    const [userCompletedTestsIds, setUserCompletedTestsIds] = useState<CompletedTestDto[] | undefined>();

    const setTests = async () => {
        let response = await TestService.GetAllTests();
        setUserTests(response);
    }

    const GetCompletedIds = async () => {
        setUserCompletedTestsIds(await TestService.GetAllUserPassedTestIds());
    }

    useEffect(() => {
        setTests();
        GetCompletedIds();
    }, []);

    const TryGetMark = (specificId: number) => {
        const commonObjects = userCompletedTestsIds?.filter(obj1 =>obj1.testId == specificId);
        if (commonObjects && commonObjects.length > 0) {
            return commonObjects[0].mark;
        } else {
            return undefined;
        }
    }


    return (
        <div>
            {userTests != undefined && userTests.length > 0 ?
                <div className="tests-container">
                    {userTests.map(i =>
                        <TestCard key={i.id} id={i.id} title={i.title} category={i.category} description={i.description} mark={TryGetMark(i.id)} />)}
                </div>
                : <div className="no-tests">
                    <h1>No available tests .</h1>
                </div>
            }
        </div>
    )
}