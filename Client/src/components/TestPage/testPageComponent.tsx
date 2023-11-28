import { useEffect, useState } from "react";
import { Question, Test } from "../types";
import "./testPageComponentStyle.css";
import { useLocation, useNavigate } from "react-router-dom";
import TestService from "../../Services/test.service";
import QuestionBlock from "./QuestionBlock/QuestionBlockComponent";

export default function TestsPage() {
    const location = useLocation();
    const navigate = useNavigate();
    const testId = new URLSearchParams(location.search).get('testId');

    const [questions, setQuestions] = useState<Question[]>();
    const [test, setTest] = useState<Test>();

    const setTestQuestions = async () => {
        let response = await TestService.GetTestQuestionsWithAnswers(Number(testId));
        setQuestions(response);
    }

    const setCurrentTest = async () =>{
        let response = await TestService.GetTest(Number(testId));
        setTest(response);
    }
    
    useEffect(() => {
        if (!testId) {
            navigate("/");
        }
        else {
            setCurrentTest();
            setTestQuestions();
        }
    }, []);

    return (
        <div className="questions-container">
            <h1>{test?.title}</h1>
            {questions?.map(question => (
                <QuestionBlock question={question}/>
            ))}
        </div>
    )
}