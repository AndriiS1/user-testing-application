import Box from '@mui/material/Box';
import Card from '@mui/material/Card';
import CardActions from '@mui/material/CardActions';
import CardContent from '@mui/material/CardContent';
import Button from '@mui/material/Button';
import Typography from '@mui/material/Typography';
import CardMedia from '@mui/material/CardMedia';
import { TestCategory } from '../../types';
import { useNavigate } from 'react-router-dom';
import { useEffect, useState } from 'react';
import "./testCardComponentStyle.css";

const mathCardBackground = require("../../../Static/Images/Cards/math-card-back.jpg");
const programmingCardBackground = require("../../../Static/Images/Cards/programming-card-back.jpg");
const spaceCardBackground = require("../../../Static/Images/Cards/space-card-back.jpg");

export default function TestCard(props: { id: number, title: string, category: number, description: string }) {
  const navigate = useNavigate();
  const[backgroundUrl, setBackgroundUrl] = useState();
  const startHandler = () => {
    navigate(`/test?testId=${props.id}`);
  }

  useEffect(() => {
    if (TestCategory[props.category] == "Math") {
      setBackgroundUrl(mathCardBackground);
    }
    else if (TestCategory[props.category] == "Programming") {
      setBackgroundUrl(programmingCardBackground);
    }
    else if (TestCategory[props.category] == "Space") {
      setBackgroundUrl(spaceCardBackground);
    }
  });


  return (
    <Card sx={{ minWidth: 275, maxWidth: 400, margin: 2 }} className='card-wrap'>
      <CardMedia
        component="img"
        sx={{ height: 140 }}
        src={backgroundUrl}
        title="green iguana"
      />
      <CardContent>
        <Typography sx={{ fontSize: 14 }} color="text.secondary" gutterBottom>
          {TestCategory[props.category]}
        </Typography>
        <Typography variant="h5" component="div">
          {props.title}
        </Typography>
        <Typography variant="body2">
          {props.description}
        </Typography>
      </CardContent>
      <CardActions className='start-button-wrap'>
        <Button size="small" onClick={startHandler}>Start test</Button>
      </CardActions>
    </Card>
  );
}