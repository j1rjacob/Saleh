export interface Risk {
  id: number;
  issue: string;
  riskdate: Date;
  impact: string;
  correctiveaction: string;
  owner: string;
  status: string;
}
