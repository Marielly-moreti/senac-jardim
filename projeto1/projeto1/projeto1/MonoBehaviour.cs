using System;
using System.Threading;

namespace projeto1
{
    public abstract class MonoBehaviour
    {
        private Thread t;
        private bool ativo = true;

        public void Run()
        {
            Awake();
            Start();

            t = new Thread(
                () => {
                    while (ativo)
                    {
                        Update();
                        LateUpdate();
                        Thread.Sleep(800);
                    }

                    OnDestroy();
                }
                
            );

            t.Start();

        }

        public void Stop()
        {
            this.ativo = false;
            t.Join();
        }

        public virtual void Awake() { }
        public virtual void Start() { }
        public virtual void Update() { }
        public virtual void LateUpdate() { }
        public virtual void OnDestroy()
        {

        }
    }
}
