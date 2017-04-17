import { HttpClient } from 'aurelia-fetch-client';
import { inject } from 'aurelia-framework';

interface DailyLogModel {
    action: string;
    startDate: Date;
    endDate: Date;
    notes: string;
}

@inject(HttpClient)
export class DailyLog {
    public dailyLogs: DailyLogModel[];

    constructor(http: HttpClient) {
        http.fetch('/api/DailyLogs/DailyLogsData')
            .then(result => result.json() as Promise<DailyLogModel[]>)
            .then(data => {
                this.dailyLogs = data;
            });
    }
}