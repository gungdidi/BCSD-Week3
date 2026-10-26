/*
public class ExampleCode : MonoBehaviour
{
    // 메소드 Method
    public class Calculator
    {
        public int Add(int num1, int num2)
        {
            int result = num1 + num2;
            return result;
        }

        public void multiple(int num1, int num2)
        {
            int result = num1 * num2;
            Debug.Log($"{num1}x{num2}={result}");
        }
    }

    // return
    private void Awake()
    {
        int a = Max(10, 20);
        Debug.Log(Max(100, 200));
        Max(5, 10);
    }

    public int Max(int num1, int num2)
    {
        if (num1 > num2)
        {
            return num1;
        }

        return num2;
    }

    // 값에 의한 전달
    private void Awake()
    {
        int a = 3, b = 4;

        Debug.Log($"Before a={a}, b={b}");
        swap(a, b);
        Debug.Log($"After a={a}, b={b}");
    }

    public void swap(int num1, int num2)
    {
        int temp = num1;
        num1 = num2;
        num2 = temp;
    }

    // 클래스
    public class Player
    {
        private string ID = "고박사";
        private int currentHP = 1000;

        public void TakeDamage(int damage)
        {
            if (currentHP > damage)
            {
                currentHP -= damage;
            }
        }
    }

    // 접근 지정자
    public class Player
    {
        public string ID;
        private int currentHP;

        void RecoveryHP(int hp)
        {
            currentHP += hp;
        }

        public void TakeDamage(int damage)
        {
            if (currentHP > damage)
            {
                currentHP -= damage;
            }
        }
    }

    // 얕은 복사
    private Player player1;
    private Player player2;

    private void Awake()
    {
        player1 = new Player("고박사", 1000);
        player2 = player1;
        player2.ID = "유니티";

        Debug.Log($"ID : {player1.ID}");
        Debug.Log($"ID : {player2.ID}");
    }

    // this() 생성자
    public class Player
    {
        private string ID;
        private int currentHP;
        private int currentMP;

        public Player()
        {
            ID = "고박사";
        }

        public Player(int hp) : this()
        {
            currentHP = hp;
        }

        public Player(int hp, int mp) : this(hp)
        {
            currentMP = mp;
        }
    }
}
*/

/*
// 추상 클래스
public abstract class Entity
{
    protected int damage;
    protected int currentHP;

    public abstract void Attack(Entity target);

    public void TakeDamage(int damage)
    {
        if (currentHP > damage)
        {
            currentHP -= damage;
            Debug.Log($"체력이 {damage}만큼 감소");
        }
        else
        {
            Debug.Log("Die");
        }
    }
}

// 읽기 전용 프로퍼티
public class Player
{
    private int currentHP;

    public int CurrentHP
    {
        get => currentHP;
    }
}
/*
public class NewMonoBehaviourScript : MonoBehaviour
{
    // 메소드
    public class Calculator
    {
        public int Add(int num1, int num2)
        {
            int result = num1 + num2;
            return result;
        }

        public void multiple(int num1, int num2)
        {
            int result = num1 * num2;
            Debug.Log($"{num1}x{num2}={result}");
        }
    }

    // return
    private void Awake()
    {
        int a = Max(10, 20);
        Debug.Log(Max(100, 200));
        Max(5, 10);
    }

    public int Max(int num1, int num2)
    {
        if (num1 > num2)
        {
            return num1;
        }

        return num2;
    }

    // 값에 의한 전달
    private void Awake()
    {
        int a = 3, b = 4;

        Debug.Log($"Before a={a}, b={b}");
        swap(a, b);
        Debug.Log($"After a={a}, b={b}");
    }

    public void swap(int num1, int num2)
    {
        int temp = num1;
        num1 = num2;
        num2 = temp;
    }

    // 클래스 Class
    public class Player
    {
        private string ID = "고박사";
        private int currentHP = 1000;

        public void TakeDamage(int damage)
        {
            if (currentHP > damage)
            {
                currentHP -= damage;
            }
        }
    }

    // 접근 지정자
    public class Player
    {
        public string ID;
        private int currentHP;

        void RecoveryHP(int hp)
        {
            currentHP += hp;
        }

        public void TakeDamage(int damage)
        {
            if (currentHP > damage)
            {
                currentHP -= damage;
            }
        }
    }

    // 얕은? 복사
    private Player player1;
    private Player player2;

    private void Awake()
    {
        player1 = new Player("고박사", 1000);
        player2 = player1;
        player2.ID = "유니티";

        Debug.Log($"ID : {player1.ID}");
        Debug.Log($"ID : {player2.ID}");
    }

    // this() 생성자
    public class Player
    {
        private string ID;
        private int currentHP;
        private int currentMP;

        public Player()
        {
            ID = "고박사";
        }

        public Player(int hp) : this()
        {
            currentHP = hp;
        }

        public Player(int hp, int mp) : this(hp)
        {
            currentMP = mp;
        }
    }
}
*/

/*
// 추상 클래스 Class
public abstract class Entity
{
    protected int damage;
    protected int currentHP;

    public abstract void Attack(Entity target);

    public void TakeDamage(int damage)
    {
        if (currentHP > damage)
        {
            currentHP -= damage;
            Debug.Log($"체력이 {damage}만큼 감소");
        }
        else
        {
            Debug.Log("Die");
        }
    }
}

// 읽기 전용 Property
public class Player
{
    private int currentHP;

    public int CurrentHP
    {
        get => currentHP;
    }
}

// 쓰기 전용 Property
public class Player
{
    private int currentHP;

    public int CurrentHP
    {
        set => currentHP = value;
    }
}
*/

// 쓰기 전용 Property
public class Player
{
    private int currentHP;

    public int CurrentHP
    {
        set => currentHP = value;
    }
}
