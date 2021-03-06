﻿using System;
using System.Linq.Expressions;

namespace Ejdb.DB
{
	public class QueryBuilder<TDocument> : QueryBuilderBase<QueryBuilder<TDocument>>
	{
		protected override QueryBuilder<TDocument> This()
		{
			return this;
		}



		public QueryBuilder<TDocument> EQ<TMember>(Expression<Func<TDocument, TMember>> memberExpression, TMember value)
		{
			return EQ(_GetFieldName(memberExpression), value);
		}

		public QueryBuilder<TDocument> EqualsIgnoreCase(Expression<Func<TDocument, string>> memberExpression, string value)
		{
			return EqualsIgnoreCase(_GetFieldName(memberExpression), value);
		}

		public QueryBuilder<TDocument> BeginsWith(Expression<Func<TDocument, string>> memberExpression, string value)
		{
			return BeginsWith(_GetFieldName(memberExpression), value);
		}

		public QueryBuilder<TDocument> EndsWith(Expression<Func<TDocument, string>> memberExpression, string value)
		{
			return EndsWith(_GetFieldName(memberExpression), value);
		}

		public QueryBuilder<TDocument> GT<TMember>(Expression<Func<TDocument, TMember>> memberExpression, TMember value)
		{
			return GT(_GetFieldName(memberExpression), value);
		}

		public QueryBuilder<TDocument> GTE<TMember>(Expression<Func<TDocument, TMember>> memberExpression, TMember value)
		{
			return GTE(_GetFieldName(memberExpression), value);
		}

		public QueryBuilder<TDocument> LT<TMember>(Expression<Func<TDocument, TMember>> memberExpression, TMember value)
		{
			return LT(_GetFieldName(memberExpression), value);
		}

		public QueryBuilder<TDocument> LTE<TMember>(Expression<Func<TDocument, TMember>> memberExpression, TMember value)
		{
			return LTE(_GetFieldName(memberExpression), value);
		}

		public QueryBuilder<TDocument> In<TMember>(Expression<Func<TDocument, TMember>> memberExpression, params TMember[] comparisonValues)
		{
			return In(_GetFieldName(memberExpression), comparisonValues);
		}

		public QueryBuilder<TDocument> NotIn<TMember>(Expression<Func<TDocument, TMember>> memberExpression, params TMember[] comparisonValues)
		{
			return NotIn(_GetFieldName(memberExpression), comparisonValues);
		}

		public QueryBuilder<TDocument> NotEquals<TMember>(Expression<Func<TDocument, TMember>> memberExpression, TMember value)
		{
			return NotEquals(_GetFieldName(memberExpression), value);
		}

		public QueryBuilder<TDocument> Not<TMember>(Expression<Func<TDocument, TMember>> memberExpression, PartialQuery<TMember> query)
		{
			return Not(_GetFieldName(memberExpression), query);
		}

		public QueryBuilder<TDocument> Between<TMember>(Expression<Func<TDocument, TMember>> memberExpression, TMember comparisonValue1, TMember comparisonValue2)
		{
			return Between(_GetFieldName(memberExpression), comparisonValue1, comparisonValue2);
		}

		public QueryBuilder<TDocument> Exists<TMember>(Expression<Func<TDocument, TMember>> memberExpression)
		{
			return Exists(_GetFieldName(memberExpression));
		}

		public QueryBuilder<TDocument> NotExists<TMember>(Expression<Func<TDocument, TMember>> memberExpression)
		{
			return NotExists(_GetFieldName(memberExpression));
		}

		public QueryBuilder<TDocument> StringMatchesAllTokens(Expression<Func<TDocument, string>> memberExpression, params string[] values)
		{
			return StringMatchesAllTokens(_GetFieldName(memberExpression), values);
		}

		public QueryBuilder<TDocument> StringMatchesAnyTokens(Expression<Func<TDocument, string>> memberExpression, params string[] values)
		{
			return StringMatchesAnyTokens(_GetFieldName(memberExpression), values);
		}

		public QueryBuilder<TDocument> ElemMatch<TProperty>(Expression<Func<TDocument, TProperty>> memberExpression, params IQuery[] queries)
		{
			return ElemMatch(_GetFieldName(memberExpression), queries);
		}

		private string _GetFieldName<TMember>(Expression<Func<TDocument, TMember>> memberExpression)
		{
			return DynamicReflectionHelper.GetProperty(memberExpression).Name;
		}
	}

	public class QueryBuilder : QueryBuilderBase<QueryBuilder>
	{
		protected override QueryBuilder This()
		{
			return this;
		}
	}
}