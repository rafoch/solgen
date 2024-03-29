export default function Page(){
    const dateNow = new Date();
    const beginDate = new Date(2019,1, 1);
    const milliDiff: number = dateNow.getTime()
    - beginDate.getTime();
    const totalSeconds = Math.floor(milliDiff / 1000);
 
    // Total number of minutes in the difference
    const totalMinutes = Math.floor(totalSeconds / 60);
     
    const totalHours = Math.floor(totalMinutes / 60);

    const totalDays = Math.floor(totalHours / 24)

    const totalYears = Math.floor(totalDays / 365)
    return (
    <div className="w-full container flex items-center flex-col justify-start gap-4">
        <section>About me as a developer. Hello, my name is <b>Rafał</b></section>
        <section>For now I've got {totalYears} years of experience in .NET. I've also got a skills in NEXT.JS and JAVA</section>
        <section>Contact me via email: rafal.ochotny95@gmail.com</section>
    </div>
    )
}