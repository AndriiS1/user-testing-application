import { useEffect, useState } from "react";
import { Answer, Question, Test } from "../types";
import "./testPageComponentStyle.css";
import { useLocation, useNavigate } from "react-router-dom";
import TestService from "../../Services/test.service";
import QuestionBlock from "./QuestionBlock/QuestionBlockComponent";
import { Box, Button, Modal, Typography } from "@mui/material";

export default function TestsPage() {
    const location = useLocation();
    const navigate = useNavigate();
    const [open, setOpen] = useState<boolean>(false);
    const [mark, setMark] = useState<number>(0);
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

    const handleSubmit = async () => {
        if (userAnswers.length == questions.length) {
            let response = await TestService.GetMark(userAnswers);
            let markInPercents = response*100;
            await setMark(markInPercents)
            TestService.PassTest(Number(test?.id), markInPercents)
            setOpen(true);
        }
    }

    const handleClose = () => {
        setOpen(false);
        navigate("/");
    }

    return (
        <>
            <Modal
                open={open}
                onClose={handleClose}
                aria-labelledby="modal-modal-title"
                aria-describedby="modal-modal-description"
            >
                <Box className='box-style'>
                    <Typography id="modal-modal-title" variant="h6" component="h2">
                        Congratulations
                    </Typography>
                    <Typography id="modal-modal-description" sx={{ mt: 2 }}>
                        {`Your mark is: ${mark}%`}
                    </Typography>
                </Box>
            </Modal>
            <div className="questions-container">
                <h1>{test?.title}</h1>
                {questions?.map(question => (
                    <QuestionBlock key={question.id} question={question} questionIndex={questions.indexOf(question)} setAnswer={setUserAnswer} />
                ))}
                <Button onClick={handleSubmit}>Submit</Button>
            </div>
        </>
    )
}