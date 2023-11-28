import Box from '@mui/material/Box';
import Card from '@mui/material/Card';
import CardActions from '@mui/material/CardActions';
import CardContent from '@mui/material/CardContent';
import Button from '@mui/material/Button';
import Typography from '@mui/material/Typography';
import CardMedia from '@mui/material/CardMedia';
import { TestCategory } from '../../types';

const bull = (
  <Box
    component="span"
    sx={{ display: 'inline-block', mx: '2px', transform: 'scale(0.8)' }}
  >
    •
  </Box>
);

const mathCardBackground = require("../../../Static/Images/Cards/math-card-back.jpg");
export default function TestCard(props: { title: string, category: number, description: string }) {
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
          {props.category}
        </Typography>
        <Typography variant="h5" component="div">
          {props.title}
        </Typography>
        <Typography variant="body2">
          {props.description}
          <br />
          {'"a benevolent smile"'}
        </Typography>
      </CardContent>
      <CardActions>
        <Button size="small">Start test</Button>
      </CardActions>
    </Card>
  );
}