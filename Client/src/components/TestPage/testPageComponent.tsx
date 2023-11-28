import { useEffect, useState } from "react";
import { Question } from "../types";
import "./testPageComponentStyle.css";
import { useLocation, useNavigate } from "react-router-dom";
import TestService from "../../Services/test.service";

export default function TestsPage() {
    const location = useLocation();
    const navigate = useNavigate();
    const testId = new URLSearchParams(location.search).get('testId');

    const [questions, setQuestions] = useState<Question[]>();

    const setTestQuestions = async () => {
        let response = await TestService.GetTestsQuestionsWithAnswers();
        console.log(response);
        setQuestions(response);
    }

    useEffect(() => {
        if (!testId) {
            navigate("/");
        }
        else {
            setTestQuestions();
        }
    }, []);

    return (
        <div className="questions-container">   
            {questions?.map(question => (
                <div key={question.id}>
                    <h3>{question.title}</h3>
                </div>
            ))}
        </div>
    )
}