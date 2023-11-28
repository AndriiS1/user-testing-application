import RadioGroup from "@mui/material/RadioGroup";
import { Question } from "../../types";
import "./QuestionBlockComponentStyle.css";
import FormControlLabel from "@mui/material/FormControlLabel";
import { Radio } from "@mui/material";

export default function QuestionBlock(props: { question: Question }) {
    return (
        <div className="question-container">
            <h3>{props.question.title}</h3>
            <RadioGroup>
                {props.question.answers.map(answer =>
                    <FormControlLabel value={answer.id} sx={{fontSize:500}} control={<Radio />} label={answer.title} />)}
            </RadioGroup>
        </div>
    )
}