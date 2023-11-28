export type Test = {
  id: number
  title: string
  category: number
  description: string
};

export type Question = {
  id: number
  title: string
  answers: Answer[]
}

export type Answer = {
  id: number
  title: string
}

export enum TestCategory {
  Space,
  Programming,
  Math
}