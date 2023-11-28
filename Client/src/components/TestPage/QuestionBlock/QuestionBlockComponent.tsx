import RadioGroup from "@mui/material/RadioGroup";
import { Answer, Question } from "../../types";
import "./QuestionBlockComponentStyle.css";
import FormControlLabel from "@mui/material/FormControlLabel";
import { Radio } from "@mui/material";
import { useState } from "react";

export default function QuestionBlock(props: { question: Question, questionIndex:number, setAnswer: (questionIndex: number, answer: Answer) => void }) {
    return (
        <div className="question-container">
            <h3>{props.question.title}</h3>
            <RadioGroup>
                {props.question.answers.map(answer =>
                    <FormControlLabel key={answer.id} onClick={() => props.setAnswer(props.questionIndex, answer)} value={answer.id} sx={{ fontSize: 500 }} control={<Radio />} label={answer.title} />)}
            </RadioGroup>
        </div>
    )
}