import dayjs, { Dayjs } from "dayjs"

export const getDateTodayVN = () => {
    return dayjs.locale("vi")
}