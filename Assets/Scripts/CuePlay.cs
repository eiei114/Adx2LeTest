using UnityEngine;

public class CuePlay : MonoBehaviour
{
    private CriAtomSource _atomSrc;

    void Start() {
        /* CriAtomSource を取得 */
        _atomSrc = GetComponent<CriAtomSource>();
    }
/// <summary>
/// サウンド再生
/// </summary>
    public void PlaySound() {
        if (_atomSrc != null) {
            _atomSrc.Play();
        }
    }
/// <summary>
/// 再生と停止がこの関数を呼ぶごとに交互に起きる
/// </summary>
    public void PlayAndStopSound() {
        if (_atomSrc != null) {
            /* CriAtomSource の状態を取得 */
            CriAtomSource.Status status = _atomSrc.status;
            if ((status == CriAtomSource.Status.Stop) || (status == CriAtomSource.Status.PlayEnd)) {
                /* 停止状態なので再生 */
                _atomSrc.Play();
            } else {
                /* 再生中なので停止 */
                _atomSrc.Stop();
            }
        }
    }
}
