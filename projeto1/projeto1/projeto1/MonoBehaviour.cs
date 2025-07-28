using System;
using System.Threading;

namespace projeto1
{
    public abstract class MonoBehaviour
    {
        private Thread t;
        private bool ativo = true;
        public bool visible = true;
        public bool input = true;

        public void Run()
        {
            ativo = true;
            Awake();
            Start();

            t = new Thread(
                () => {
                    while (ativo)
                    {
                        Update();
                        LateUpdate();
                        Thread.Sleep(500);
                    }


                }

            );

            t.Start();

        }

        public void Stop()
        {
            this.ativo = false;
            OnDestroy();
            t.Join();
        }

        public virtual void Awake() { }
        public virtual void Start() { }
        public virtual void Update() { }
        public virtual void LateUpdate() { }
        public virtual void OnDestroy() { }
        public abstract void Draw();
    }
}
