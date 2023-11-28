import { useEffect, useState } from "react";
import { Answer, Question, Test } from "../types";
import "./testPageComponentStyle.css";
import { useLocation, useNavigate } from "react-router-dom";
import TestService from "../../Services/test.service";
import QuestionBlock from "./QuestionBlock/QuestionBlockComponent";
import { Button } from "@mui/material";

export default function TestsPage() {
    const location = useLocation();
    const navigate = useNavigate();
    const testId = new URLSearchParams(location.search).get('testId');

    const [questions, setQuestions] = useState<Question[]>([]);
    const [test, setTest] = useState<Test>();
    const [userAnswers, setUserAnswers] = useState<Answer[]>(Array.from({ length: questions?.length }));

    const setTestQuestions = async () => {
        let response = await TestService.GetTestQuestionsWithAnswers(Number(testId));
        setQuestions(response);
    }

    const setCurrentTest = async () => {
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

    const setUserAnswer = (questionIndex: number, answer: Answer) => {
        setUserAnswers(prevAnswers => {
            const newAnswers = [...prevAnswers];
            newAnswers[questionIndex] = answer;
            return newAnswers;
        });
    }

    const getMark= async () => {
        let response = await TestService.GetMark(userAnswers);
        console.log(response)
    }


    return (
        <div className="questions-container">
            <h1>{test?.title}</h1>
            {questions?.map(question => (
                <QuestionBlock key={question.id} question={question} questionIndex={questions.indexOf(question)} setAnswer={setUserAnswer} />
            ))}
            <Button onClick={getMark}>Submit</Button>
        </div>
    )
}