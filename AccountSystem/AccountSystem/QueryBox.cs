using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.Linq.Expressions;

namespace AccountSystem {
    public partial class QueryBox : UserControl {
        public QueryBox() {
            InitializeComponent();
        }

        public void Initialize(IEnumerable<QueryBoxItemBase> ienum) {
            comboBoxSearch.setCombobox(ienum, "DisplayName");
        }

        public IOption<Expression<Func<T, bool>>> FilterOpt<T>() {
            var text = textBoxSearch.Text;
            var check1 = string.IsNullOrEmpty(text);
            var check2 = comboBoxSearch.SelectedIndex != -1;
            if (!string.IsNullOrEmpty(text) && comboBoxSearch.SelectedIndex != -1) {
                var type = comboBoxSearch.SelectedItem.GetType().GetGenericArguments()[1];
                var validated = ((QueryBoxItemBase)(comboBoxSearch.SelectedItem)).validate(textBoxSearch.Text);
                if (type == typeof(int)) {
                   var filter = ((QueryBoxItem<T, int>)(comboBoxSearch.SelectedItem))
                          .FilterBaseOpt
                          .Select(q => q(validated.To<int>()))
                          .ToOption();
                    return filter;
                }
                else if (type == typeof(string)) {
                    return ((QueryBoxItem<T, string>)(comboBoxSearch.SelectedItem))
                         .FilterBaseOpt
                         .Select(q => q(validated))
                         .ToOption();
                }
                else
                    return Option.None<Expression<Func<T, bool>>>();
            }
            else
                return Option.None<Expression<Func<T, bool>>>();
        }

    }
}

public class QueryBoxItem<T, U> : QueryBoxItemBase {
    public IOption<Func<U, Expression<Func<T, bool>>>> FilterBaseOpt { get; set; }
    public QueryBoxItem() {
        FilterBaseOpt = Option.None<Func<U, Expression<Func<T, bool>>>>();
        validate = s => s;
    }
}

public class QueryBoxItemBase {
    public QueryBoxItemBase() {
        DisplayName = "";
        validate = s => s;
    }
    public string DisplayName { get; set; }

    public Func<string, string> validate;
}

#region Option
public interface IOption<out T> : IEnumerable<T> {
    bool HasValue { get; }
}

sealed public class Some<T> : IOption<T> {
    private readonly T val;
    public bool HasValue { get { return true; } }

    public Some(T v) {
        val = v;
    }

    public IEnumerator<T> GetEnumerator() {
        yield return val;
    }

    IEnumerator IEnumerable.GetEnumerator() {
        return this.GetEnumerator();
    }
}

sealed public class None<T> : IOption<T> {
    public bool HasValue { get { return false; } }

    public None() { }

    public IEnumerator<T> GetEnumerator() {
        yield break;
    }

    IEnumerator IEnumerable.GetEnumerator() {
        return this.GetEnumerator();
    }
}
static public class Option {
    public static Some<T> Some<T>(T u) {
        return new Some<T>(u);
    }

    public static None<T> None<T>() {
        return new None<T>();
    }

    public static IOption<T> Return<T>(T u) {
        if (u == null)
            return Some<T>(u);
        else
            return None<T>();
    }

    public static IOption<U> Bind<T, U>(this IOption<T> _, Func<T, IOption<U>> f) {
        return _.HasValue ? f(_.First()) : Option.None<U>();
    }

    static public IOption<T> ToOption<T>(this IEnumerable<T> u) {
        var l = u.Take(1).ToList();
        if (l.Count > 0)
            return Option.Some<T>(l.First());
        else
            return None<T>();
    }

    static public U Match<T, U>(this IOption<T> _, Func<T, U> Some, Func<U> None) {
        return _.HasValue ? Some(_.First()) : None();
    }

    static public void Match<T>(this IOption<T> _, Action<T> Some, Action None) {
        if (_.HasValue)
            Some(_.First());
        else
            None();
    }

    #endregion
}
static public class Extensions {
    public static T To<T>(this string _) {
        T result = (T)TypeDescriptor.GetConverter(typeof(T)).ConvertFrom(_);
        return result;
    }

    public static void setCombobox<T>(this ComboBox comb, IEnumerable<T> list, string displayMem) {
        comb.Items.Clear();
        comb.Enabled = true;

        foreach (var i in list) {
            comb.Items.Add(i);
        }

        comb.DisplayMember = displayMem;
        comb.DropDownStyle = ComboBoxStyle.DropDownList;
    }
}
