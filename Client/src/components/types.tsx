export type ProcessTask = {
  id: number;
  startDate: Date
  endDate: Date
  stringA: String
  stringB: String
  result: String
  isCanceled: boolean
  active: boolean
};

export const tokenConfig = {
  headers: {
    'Authorization': `Bearer ${localStorage.getItem("jwtToken")}`
  }
};

export type TaskProgress = {
  processId: number,
  percentage: number
};