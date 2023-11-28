import Box from '@mui/material/Box';
import Card from '@mui/material/Card';
import CardActions from '@mui/material/CardActions';
import CardContent from '@mui/material/CardContent';
import Button from '@mui/material/Button';
import Typography from '@mui/material/Typography';
import CardMedia from '@mui/material/CardMedia';
import { TestCategory } from '../../types';
import { useNavigate } from 'react-router-dom';

const mathCardBackground = require("../../../Static/Images/Cards/math-card-back.jpg");
const programmingCardBackground = require("../../../Static/Images/Cards/programming-card-back.jpg");
const spaceCardBackground = require("../../../Static/Images/Cards/space-card-back.jpg");

export default function TestCard(props: { id:number, title: string, category: number, description: string }) {
  const navigate = useNavigate();

  const startHandler = () =>{
    navigate(`/test?testId=${props.id}`);
  }

  return (
    <Card sx={{ minWidth: 275, maxWidth: 400, margin: 2 }}>
      <CardMedia
        component="img"
        sx={{ height: 140 }}
        src={TestCategory[props.category] == "Math" ? mathCardBackground : ""}
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
      <CardActions>
        <Button size="small" onClick={startHandler}>Start test</Button>
      </CardActions>
    </Card>
  );
}