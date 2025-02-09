// Recursion Countdown
CountDown(15);


void CountDown(int num)
{
  if (num == 0) return;
  Console.WriteLine(num);
  CountDown(num - 1);
}
