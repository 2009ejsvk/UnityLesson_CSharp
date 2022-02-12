using System;
// switch-case 에 적합한 형태
// 각 요소들이 동시에 일어나는 경우가 없는 상황에 적합한 형태
// 특히 FSM (Finite State Machine)
// 절차적으로 시행해야할 때 쓰면 된다고 하던데요

enum e_PlayerState
{
    // 콤마로 열거
    // 정수로 들어감 ( 그 정수를 비트로 환산하면 됨 )

    Idel,
    Attack,
    Jump,
    Walk,
    Run,
    Dash,
    Home,
}

[Flags]
// 플래그 속성이 설정된 있는 열거형 멤버는 집합처리가 되어 선언되지 않은 값들도 자동으로 처리됩니다.
// if 나 switch 말고 이거 쓰면 중복 항목 해결 쌉가능
enum e_PlayerStateFlags
{
    Idel    = 0,
    Attack  = 1 << 0, // 00000001
    Jump    = 1 << 1, // 00000010
    Walk    = 1 << 2, // 00000100
    Run     = 1 << 3, // 00001000
    Dash    = 1 << 4, // 00010000
    Home    = 1 << 5, // 00100000

    DashAttack = Attack | Dash, // 00010001
    //JumpAttack = Attack | Jump    // 00000011
}

namespace UnityLesson_CSharp_EnnumAndSwitchCase
{

    public class Warrior
    {
        public string name;
        public void Attack()
        {
            Console.WriteLine(name + "이 공격");
        }
        public void Jump() 
        {
            Console.WriteLine(name + "이 점프");
        }
        public void Walk()
        {
            Console.WriteLine(name + "이 걸음");
        }
        public void Run()
        {
            Console.WriteLine(name + "이 달림");
        }
        public void Dash()
        {
            Console.WriteLine(name + "이 돌진");
        }
        public void Home()
        {
            Console.WriteLine(name + "이 귀한");
        }
    }

    internal class Program
    {
        //Casting 캐스팅
        //static e_PlayerState creatMotion = e_PlayerState.Attack;
        static e_PlayerState creatMotion = (e_PlayerState)1;

        static void Main(string[] args)
        {
            e_PlayerStateFlags flags = e_PlayerStateFlags.Jump | e_PlayerStateFlags.Attack;
            Console.WriteLine(flags);

            Warrior warrior = new Warrior();

            // switch - case 분기
            switch (flags)
            {
                case e_PlayerStateFlags.Idel:
                    break;
                case e_PlayerStateFlags.Attack:
                    warrior.Attack();
                    break;
                case e_PlayerStateFlags.Jump:
                    warrior.Jump();
                    break;
                case e_PlayerStateFlags.Walk:
                    warrior.Walk();
                    break;
                case e_PlayerStateFlags.Run:
                    warrior.Run();
                    break;
                case e_PlayerStateFlags.Dash:
                    warrior.Dash();
                    break;
                case e_PlayerStateFlags.Home:
                    warrior.Home();
                    break;
                default:
                    break;
            }

            
            Console.WriteLine("전사 이름 입력");
            warrior.name = Console.ReadLine();
            Console.WriteLine(warrior.name);

            // if 분기
            if (creatMotion == e_PlayerState.Idel)
            {

            }
            else if (creatMotion == e_PlayerState.Attack)
            {
                warrior.Attack();
            }
            else if (creatMotion == e_PlayerState.Jump)
            {
                warrior.Jump();
            }
            else if (creatMotion == e_PlayerState.Walk)
            {
                warrior.Walk();
            }
            else if (creatMotion == e_PlayerState.Run)
            {
                warrior.Run();
            }
            else if (creatMotion == e_PlayerState.Dash)
            {
                warrior.Dash();
            }
            else if (creatMotion == e_PlayerState.Home)
            {
                warrior.Home();
            }
            else
            {
                Console.WriteLine("오류");
            }


            // switch - case 분기
            switch (creatMotion)
            {
                case e_PlayerState.Idel:
                    break;
                case e_PlayerState.Attack:
                    warrior.Attack();
                    break;
                case e_PlayerState.Jump:
                    warrior.Jump();
                    break;
                case e_PlayerState.Walk:
                    warrior.Walk();
                    break;
                case e_PlayerState.Run:
                    warrior.Run();
                    break;
                case e_PlayerState.Dash:
                    warrior.Dash();
                    break;
                case e_PlayerState.Home:
                    warrior.Home();
                    break;
                default:
                    break;
            }

            Console.WriteLine("전사에게 명령을");
            string motionInput = Console.ReadLine();
            // e_PlayerState motion = (e_PlayerState)Enum.Parse(typeof(e_PlayerState), motionInput);
            e_PlayerState motion;
            bool isParsed = Enum.TryParse(motionInput, out motion);
            if (isParsed)
            {
                // switch - case 분기
                switch (motion)
                {
                    case e_PlayerState.Idel:
                        break;
                    case e_PlayerState.Attack:
                        warrior.Attack();
                        break;
                    case e_PlayerState.Jump:
                        warrior.Jump();
                        break;
                    case e_PlayerState.Walk:
                        warrior.Walk();
                        break;
                    case e_PlayerState.Run:
                        warrior.Run();
                        break;
                    case e_PlayerState.Dash:
                        warrior.Dash();
                        break;
                    case e_PlayerState.Home:
                        warrior.Home();
                        break;
                    default:
                        break;
                }
            }
            else
            {
                Console.WriteLine("오류");
            }

            Console.ReadLine();


        }
    }
}
